using MHGridMasterDetails.Model.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MHGridMasterDetails.Model.ResponseMessage
{
    public class ResponseMessage
    {
        public bool Successed { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
        public object Response { get; set; }

        private ResponseMessage(string Code, string Message, object Response = null, bool ApplyTranslation = true)
        {
            this.Code = Code;
            this.Response = Response;
            if (ApplyTranslation)
            {
                string language = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
                this.Message = TranslationService.getTranslate(Code, language);
            }
            else
            {
                this.Message = Message;
            }
        }
        public static ResponseMessage PerformSuccess(object Response = null, string Code = null, string Message = null)
        {
            var result = new ResponseMessage(Code, Message, Response, false);
            result.Successed = true;
            return result;
        }
        public static ResponseMessage PerformError(string Code = null, string Message = null, bool ApplyTranslation = true)
        {
            var result = new ResponseMessage(Code, Message, null, ApplyTranslation);
            result.Successed = false;
            return result;
        }
    }
}
