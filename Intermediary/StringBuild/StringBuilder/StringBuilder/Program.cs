using UsingSB.Entities;

Comment c1 = new Comment("Hello World");
Comment c2 = new Comment("HELPMEEE");

Post post1 = new Post(DateTime.Parse("16/06/2024 13:56:02"),
    "Just Chilling",
    "Playing Games ;D",
    240);
post1.addComment(c1);
post1.addComment(c2);

Comment c3 = new Comment("ShutUp");
Comment c4 = new Comment("Hiiii Swettie");

Post post2 = new Post(DateTime.Parse("20/06/2024 22:46:22"),
    "SOMEONEHELPME",
    "HI ITS OKAY NOW",
    13);
post2.addComment(c3);
post2.addComment(c4);


Console.WriteLine(post1);
Console.WriteLine(post2);


