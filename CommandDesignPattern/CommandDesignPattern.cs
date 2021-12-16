using System;
namespace CommandDesignPattern
{
    class Program 
    {
        static void Main(string[] args)
        {
            Document document = new ExcelDocument();
            ICommand openDocument = new OpenCommand(document);
            ICommand saveDocument = new SaveCommand(document);
            ICommand closeDocument = new CloseCommand(document);
            MenuOptions options = new MenuOptions(openDocument,saveDocument,closeDocument);
            options.ClickOpen();
            options.ClickSave();
            options.ClickClose();

            Console.ReadKey();
        }
    }
    // Receiver
    public interface Document 
    {
        void Open();
        void Save();
        void Close();
    }
    public class ExcelDocument : Document
    {
         public void Open()
         {
             Console.WriteLine("The Excel file has been Opened!");
         }
         public void Save()
         {
             Console.WriteLine("The Excel file has been saved!");
         }
         public void Close() 
         {
             Console.WriteLine("The Excel file has been Closed!");
         }
    }
    public class WordDocument : Document
    {
         public void Open()
         {
             Console.WriteLine("The Word file has been Opened!");
         }
         public void Save()
         {
             Console.WriteLine("The Word file has been saved!");
         }
         public void Close() 
         {
             Console.WriteLine("The Word file has been Closed!");
         }
    }
    public class TxtDocument : Document
    {
         public void Open()
         {
             Console.WriteLine("The Txt file has been Opened!");
         }
         public void Save()
         {
             Console.WriteLine("The Txt file has been saved!");
         }
         public void Close() 
         {
             Console.WriteLine("The Txt file has been Closed!");
         }
    }
    // Command 
    public interface ICommand
    {
        void Execute();
    }
    public class OpenCommand : ICommand
    {
        public Document document;
        public OpenCommand (Document document)
        {
            this.document  = document;
        }
        public void Execute()
        {
            document.Open();
        }
    }
    public class SaveCommand : ICommand
    {
        public Document document;
        public SaveCommand(Document document) 
        {
            this.document = document;
        }
        public void Execute()
        {
            document.Save();
        }
    }
    public class CloseCommand : ICommand 
    {
        public Document document;
        public CloseCommand(Document document) 
        {
            this.document = document;
        }
        public void Execute()
        {
            document.Close();
        }
    }
    // Invoker
    public class MenuOptions
    {
        private ICommand openCommand;
        private ICommand saveCommand;
        private ICommand closeCommand;

        public MenuOptions(ICommand open, ICommand save, ICommand close)
        {
            this.openCommand = open;
            this.saveCommand = save;
            this.closeCommand = close;
        }

        public void ClickOpen()
        {
            openCommand.Execute();
        }

        public void ClickSave()
        {
            saveCommand.Execute();
        }

        public void ClickClose()
        {
            closeCommand.Execute();
        }
    }
}