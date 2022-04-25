using HeyNow.Std.Model.Taja.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeyNow.Std.Model.Taja.App
{
    public class TajaTypingResultModel
    {
        public double Duration { get; set; } = 0;
        public int RateTyping { get; set; } = 0;
        public int CountInput { get; set; } = 0;
        public TajaTypingType TypingType { get; set; } = TajaTypingType.READY;


        public TajaTypingResultModel()
        {

        }

        public TajaTypingResultModel(double duration, int countInput)
        {
            var count = (double)countInput;
            this.RateTyping = (int)(count / duration * 60);
            this.Duration = duration;
            this.CountInput = countInput;
        }
        public TajaTypingResultModel(double duration, int countInput, TajaTypingType typingType)
        {
            
            var count = (double)countInput;
            if (countInput !=0)
                this.RateTyping = (int)(count / duration * 60);
            this.Duration = duration;
            this.CountInput = countInput;

            this.TypingType = typingType;
        }
    }
}
