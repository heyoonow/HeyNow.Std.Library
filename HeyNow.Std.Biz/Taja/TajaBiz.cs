using HeyNow.Std.Biz.Taja.Data;
using HeyNow.Std.Dac.SqlLiteRepositry.Taja;
using HeyNow.Std.Extend;
using HeyNow.Std.Model.Taja.App;
using HeyNow.Std.Model.Taja.Type;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace HeyNow.Std.Biz.Taja
{
    public partial class TajaBiz
    {
        private Stopwatch swTaja;
        public delegate void tajaTypingResultHandler(TajaTypingResultModel model);
        public tajaTypingResultHandler typingResultHandler;
        private string tajaTypingInput;
        private int countTajaHangul;
        private bool isCalculatorTyping = false;

        private TestDac dac;
        public TajaBiz(tajaTypingResultHandler typingResultHandler)
        {
            swTaja = new Stopwatch();
            this.typingResultHandler = typingResultHandler;
            tajaData = TajaData.Instance.GetData();
            random = new Random();
            dac = new TestDac();
        }

        public async void SetTajaTypingInput(string tajaInput)
        {
            await Task.Run(() =>
            {
                if (tajaInput != string.Empty)
                {
                    if (swTaja.IsRunning == false)
                        swTaja.Start();

                    if (isCalculatorTyping == false)
                        CalculatorTyping();
                }
                else
                {
                    swTaja.Reset();
                    var model = new TajaTypingResultModel(0, 0, TajaTypingType.READY);
                    this.typingResultHandler?.Invoke(model);
                }

                this.tajaTypingInput = tajaInput;
                this.countTajaHangul = tajaInput.CountHangul();

            });
        }

        private async void CalculatorTyping()
        {
            await Task.Run(async () =>
            {
                while (swTaja.IsRunning)
                {
                    try
                    {
                        isCalculatorTyping = true;
                        if (swTaja.Elapsed.TotalSeconds < 0.5)
                            continue;

                        var model = new TajaTypingResultModel(swTaja.Elapsed.TotalSeconds, countTajaHangul);
                        if (tajaTypingInput == currentTaja
                            || tajaTypingInput.Length  > currentTaja.Length + 3)
                        {
                            model.TypingType = TajaTypingType.END;
                            this.typingResultHandler?.Invoke(model);
                            swTaja.Stop();
                            break;

                        }
                        this.typingResultHandler?.Invoke(model);
                        await Task.Delay(200);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        continue;
                    }
                }

                isCalculatorTyping = false;
            });
        }
    }
}
