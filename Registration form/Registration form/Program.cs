using System;
using System.IO;

namespace Registration_form
{
  class Program
    {
        static void Main(string[] args)
        {
            string htmlContent = @"
            <!DOCTYPE html>
            <html>
            <head>
                <title>Registration Form</title>
                <style>
                    body {
                        font-family: Arial, sans-serif;
                        background-color: #f0f0f0;
                        text-align: center;
                    }

                    h1 {
                        color: #007bff;
                    }

                    .container {
                        max-width: 400px;
                        margin: 0 auto;
                        padding: 20px;
                        background-color: #fff;
                        border-radius: 5px;
                        box-shadow: 0px 0px 5px rgba(0, 0, 0, 0.2);
                    }

                    label {
                        display: block;
                        margin-bottom: 10px;
                    }

                    input[type=text], input[type=email], input[type=password] {
                        width: 100%;
                        padding: 10px;
                        margin-bottom: 20px;
                    }

                    button[type=submit] {
                        background-color: #007bff;
                        color: #fff;
                        padding: 10px 20px;
                        border: none;
                        border-radius: 5px;
                        cursor: pointer;
                    }

                    button[type=submit]:hover {
                        background-color: #0056b3;
                    }
                </style>
            </head>
            <body>
                <div class=""container"">
                    <h1>Registration Form</h1>
                    <form method=""post"" action=""register"">
                        <label for=""name"">Name:</label>
                        <input type=""text"" id=""name"" name=""name"" required>

                        <label for=""email"">Email:</label>
                        <input type=""email"" id=""email"" name=""email"" required>

                        <label for=""password"">Password:</label>
                        <input type=""password"" id=""password"" name=""password"" required>

                        <button type=""submit"">Register</button>
                    </form>
                </div>
            </body>
            </html>
            ";

            File.WriteAllText("registration.html", htmlContent);

            Console.WriteLine("Registration form generated successfully");
            Console.ReadLine();
        }
    }
}
