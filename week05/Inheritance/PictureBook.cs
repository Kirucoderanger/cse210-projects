public class PictureBook : Book
{
    private string _illustrator;
    public string GetIllustrator()
    {
        return _illustrator;
    }

    public void SetIllustrator(string illustrator)
    {
        _illustrator = illustrator;
    }

    public PictureBook() : base()
    {
        //without contractor
    }

    public PictureBook(string title, string author, string illustrator) : base(title, author)
    {
        _illustrator = illustrator;
    }

    public string GetPictureBookInfo()
    {
        return $"{base.GetTitle()} by {base.GetAuthor()} illustrated by {_illustrator}";
    }

}