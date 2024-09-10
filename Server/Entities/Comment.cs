﻿namespace Entities;

public class Comment
{
    public int Id { get; set; }
    public string Body { get; set; }
    public int PostId { get; set; }

    public Comment(string body, int postId)
    {
        Body = body;
        PostId = postId;
    }
}