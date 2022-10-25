namespace CSharp.유형
{
    public interface IControl
    {
        void Paint();
    }

    public interface ITextBox : IControl
    {
        void SetText(string text);
    }

    public interface IListBox : IControl
    {
        void SetItems(string[] items);
    }

    public interface IComboBox : ITextBox, IListBox
    {
    }
}