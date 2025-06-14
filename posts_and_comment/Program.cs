using posts_and_comment.Entities;
using System.Globalization;

Comment comment1 = new Comment("Have a nice trip!");
Comment comment2 = new Comment("Wow that's awesome!");
Post post1 = new Post(DateTime.ParseExact("21/06/2018 13:05:44", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture), "Traveling to New Zealand", "I'm going to visit this wonderful country!", 12);
post1.AddComment(comment1);
post1.AddComment(comment2);

Comment comment3 = new Comment("Good night");
Comment comment4 = new Comment("May the Force be with you");
Post post2 = new Post(DateTime.ParseExact("28/07/2018 23:14:19", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture), "Good night guys", "See you tomorrow", 5);
post2.AddComment(comment3);
post2.AddComment(comment4);

Console.WriteLine(post1);
Console.WriteLine(post2);