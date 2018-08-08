using System;
using System.Activities;
using System.ComponentModel;
using System.IO;

namespace Pramati.EML.Activities
{
    //public class ParseMSG : CodeActivity
    //{
    //    [Category("Input")]
    //    [RequiredArgument]
    //    public InArgument<string> FilePath { get; set; }


    //    [Category("Output")]
    //    public OutArgument<MsgReader.Outlook.Storage.Message> MailObject { get; set; }

    //    [Category("Output")]
    //    public OutArgument<string> Message { get; set; }

    //    protected override void Execute(CodeActivityContext context)
    //    {
    //        string filePath = FilePath.Get(context);
    //        MsgReader.Outlook.Storage.Message mailObject = null;
    //        string message = null;


    //        string fileExtension = Path.GetExtension(filePath);
    //        try
    //        {
    //            if (File.Exists(filePath))
    //            {
    //                if (fileExtension.ToLower() == ".msg")
    //                {

    //                    mailObject = new MsgReader.Outlook.Storage.Message(filePath);
    //                    MailObject.Set(context, mailObject);
    //                    if (mailObject != null)
    //                    {
    //                        message = "Success";
    //                    }


    //                }
    //            }
    //            else
    //            {
    //                message = "File doesnot exist";
    //            }



    //        }
    //        catch (Exception ex)
    //        {
    //            message = ex.Message;
    //        }
    //        finally
    //        {
    //            Message.Set(context, message);
    //        }
    //    }
    //}
}
