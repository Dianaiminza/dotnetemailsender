# FluentEmailExampleApp

A simple .NET application demonstrating how to send emails using the FluentEmail library.

## Introduction

This repository contains a basic .NET console application that demonstrates how to use the FluentEmail library to send emails via SMTP. FluentEmail is a simple email library for .NET that supports different email sending methods such as SMTP, SendGrid, Mailgun, and more.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine
- An SMTP email account (e.g., Gmail, Outlook, etc.)

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/dotnetemailsender.git
   cd FluentEmailExampleApp

2. Restore the dependencies
   ```bash
   dotnet restore

## Configuration
- Open the Program.cs file.
  
Replace the placeholder values with your SMTP email account details

  ```bash
   var sender = new SmtpSender(() => new SmtpClient("smtp.your-email-provider.com")
   {
    UseDefaultCredentials = false,
    Credentials = new NetworkCredential("your-email@example.com", "your-email-password"),
    EnableSsl = true,
    Port = 587
   });

  Email.DefaultSender = sender;
```
## Usage
Run the application:
```bash
dotnet run

