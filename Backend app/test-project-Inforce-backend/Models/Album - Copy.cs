﻿namespace test_project_Inforce_backend.Models;

public class AlbumDto
{
    public string AlbumId { get; set; }

    public virtual string UserId { get; set; }

    public List<string>? PhotoIds { get; set; }

    public string? Title { get; set; }
}