using System;
using System.Activities;
using System.ComponentModel;
using System.IO;

namespace Pramati.EML.Activities
{
    public class ParseEML : CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        public InArgument<string> FilePath { get; set; }


        [Category("Output")]
        public OutArgument<MsgReader.Mime.Message> MailObject { get; set; }

        [Category("Output")]
        public OutArgument<string> Message { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            string filePath = FilePath.Get(context);
            MsgReader.Mime.Message mailObject = null;
            string message = null;

            try
            {
                if (File.Exists(filePath))
                {
                    if (Path.GetExtension(filePath).ToLower() == ".eml")
                    {
                        Stream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
                        mailObject = MsgReader.Mime.Message.Load(stream);
                       
                        MailObject.Set(context, mailObject);
                        stream.Dispose();
                       
                        if (MailObject != null)
                        {
                            message = "Success";
                          
                        }
                    }
                }
                else
                {
                    message = "File doesnot exist";
                }
            }
            catch (Exception ex)
            {

                message = ex.Message;
            }
            finally
            {
               
                Message.Set(context, message);
                mailObject = null;
            }
        }
    }
}
