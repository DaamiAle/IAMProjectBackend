﻿namespace IAM.Domain.Entity.Model;

public class UserEntity
{
    public int Id { get; set; }
    public string DNI { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
