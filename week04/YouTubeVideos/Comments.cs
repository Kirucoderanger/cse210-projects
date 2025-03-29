using System.Runtime.InteropServices;

public class Comments
{
  public static List<List<string>> comments = new List<List<string>>();

  static Comments()
  {
    // Creating inner lists
    comments.Add(new List<string> { "video1", "Alice", "Great video!" });
    comments.Add(new List<string> { "video1", "Bob", "Very informative."});
    comments.Add(new List<string> { "video1", "Charlie", "Loved the visuals."});
    comments.Add(new List<string> { "video1", "Diana", "Thanks for sharing!"});

    comments.Add(new List<string> { "video2", "Eve", "Amazing content!"});
    comments.Add(new List<string> { "video2", "Frank", "Well explained."});
    comments.Add(new List<string> { "video2", "Grace", "This was helpful."});
    comments.Add(new List<string> { "video2", "Hank", "Keep up the good work!"});

    comments.Add(new List<string> { "video3", "Ivy", "Fantastic tutorial!"});
    comments.Add(new List<string> { "video3", "Jack", "Clear and concise."});
    comments.Add(new List<string> { "video3", "Karen", "I learned a lot."});
    comments.Add(new List<string> { "video3", "Leo", "Looking forward to more!"});

    

  }
  
}

/*
public class Comment
{
    public string Author { get; set; }
    public string Text { get; set; }

    public Comment(string author, string text)
    {
        Author = author;
        Text = text;
    }

    public override string ToString()
    {
        return $"{Author}: {Text}";
    }
}
public class Comments
{


 //public static List<Comment> GetComment()
  private static List<string> videoComment = new List<string>
        {
            "Alice: Great video!"
        };


            return new List<Video>
            {   
        // Video 1 comments
var video1Comments = new List<Comment>

    new Comment("Alice", "Great video!"),
    new Comment("Bob", "Very informative."),
    new Comment("Charlie", "Loved the visuals."),
    new Comment("Diana", "Thanks for sharing!")
            }
};

// Video 2 comments
var video2Comments = new List<Comment>
{
    new Comment("Eve", "Amazing content!"),
    new Comment("Frank", "Well explained."),
    new Comment("Grace", "This was helpful."),
    new Comment("Hank", "Keep up the good work!")
};

// Video 3 comments
var video3Comments = new List<Comment>
{
    new Comment("Ivy", "Fantastic tutorial!"),
    new Comment("Jack", "Clear and concise."),
    new Comment("Karen", "I learned a lot."),
    new Comment("Leo", "Looking forward to more!")
};

// Display comments for each video
Console.WriteLine("Video 1 Comments:");
video1Comments.ForEach(comment => Console.WriteLine(comment));

Console.WriteLine("\nVideo 2 Comments:");
video2Comments.ForEach(comment => Console.WriteLine(comment));

Console.WriteLine("\nVideo 3 Comments:");
video3Comments.ForEach(comment => Console.WriteLine(comment));*/


/*
// Accessing elements
Console.WriteLine(numbers[1][2]); // Output: 6  
}


List<List<int>> numbers = new List<List<int>>();

// Creating inner lists
numbers.Add(new List<int> { 1, 2, 3 });
numbers.Add(new List<int> { 4, 5, 6 });
numbers.Add(new List<int> { 7, 8, 9 });

// Accessing elements
Console.WriteLine(numbers[1][2]); // Output: 6



//You can add individual items to an inner list dynamically.


List<List<string>> names = new List<List<string>>();

names.Add(new List<string>()); // Add an empty inner list
names[0].Add("Alice");
names[0].Add("Bob");

Console.WriteLine(names[0][1]); // Output: Bob



//You can use nested loops to iterate over a List<List<T>>.


List<List<int>> matrix = new List<List<int>>
{
    new List<int> { 1, 2, 3 },
    new List<int> { 4, 5, 6 },
    new List<int> { 7, 8, 9 }
};

foreach (var row in matrix)
{
    foreach (var number in row)
    {
        Console.Write(number + " ");
    }
    Console.WriteLine(); // New line for each row
}


numbers.RemoveAt(1); // Removes the second inner list
numbers[0].Remove(2); // Removes `2` from the first list*/
