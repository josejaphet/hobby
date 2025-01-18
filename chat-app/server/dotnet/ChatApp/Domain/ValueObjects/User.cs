using SecurityDriven;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects;
public sealed class User
{
    public User(
        string firstname,
        string? middlename,
        string lastname,
        DateOnly dateOfBirth,
        string mobileNumber,
        string passwordHash,
        string status,
        string username,
        string emailAddress
        )
    {
        Firstname = firstname;
        Middlename = middlename;
        Lastname = lastname;
        DateOfBirth = dateOfBirth;
        MobileNumber = mobileNumber;
        PasswordHash = passwordHash;
        Status = status;
        Username = username;
        EmailAddress = emailAddress;

    }
    public Guid Id { get; set; }

    public string Firstname { get; set; }

    public string? Middlename { get; set; }

    public string Lastname { get; set; }

    public DateOnly DateOfBirth { get; set; }

    public string MobileNumber { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string PasswordHash { get; set; }

    public string Status { get; set; }

    public string Username { get; set; }

    public string EmailAddress { get; set; }

    public static User Create(
        string firstname,
        string? middlename,
        string lastname,
        DateOnly dateOfBirth,
        string mobileNumber,
        string passwordHash,
        string status,
        string username,
        string emailAddress
        )
    {
        var user = new User(
                        firstname,
                        middlename,
                        lastname, 
                        dateOfBirth, 
                        mobileNumber, 
                        passwordHash,
                        status,
                        username,
                        emailAddress)
        {
            Id = FastGuid.NewGuid()
        };
        return user;
    }
}
