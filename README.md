# HTTP_Basic_Authentication
1.0.0.0
With this NuGet package you can log in with HTTP Basic Authentication with Webrequest and Webresponse.

Usage:

1. You have to modify the project properties. So go to the root project(portable) and click double on the Properties.
2. Go to the Library and click on the Change button.
3. Uncheck the Silverlight and change the .NET Framework 4.5 to .NET Framework 4.5.1.

4.
//first step: create an object
HTTPBasicAuth httpBasicImplement = new HTTPBasicAuth();

//second step: use the object
string responseString = httpBasicImplement.GetResponseString("servername/uri","username","password");

Additional information:

You can modify the function, if you go to the HTTPBasicAuthenticationImplement folder and select the HTTPBasicAuth.cs file.

If you have a question do not hesitate to contact me: bence960206@gmail.com! :)
