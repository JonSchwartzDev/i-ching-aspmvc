# i-ching-aspmvc
ASP NET Core MVC version of the I Ching.

It was bootstrapped from the dotnet template, and contains about 1000 lines of C# (mostly boilerplate), about 175 lines of CSHTML templates, 175 lines of CSS and 1000 lines of content/data.

See https://github.com/JonSchwartzDev/i-ching-mithril for the Mithril SPA version. That app is also live at http://iching.blackoak.io/. 

This ASP MVC version uses server round trips - it is not a SPA - but is otherwise the same functionality and design as the hosted mithril version. I do intend to build .NET Core 6 Maui versions of this app to run natively on Android and iOS, but Maui has been delayed to perhaps April 2022. I may experiment with Blazor and cross-platform Uno apps before then.

There's also a React SPA version at https://github.com/JonSchwartzDev/i-ching-react 

Deploy size differences: Mithril 220K, React Webpack 800K, ASP MVC 1200K.

Comparison of code for the three versions, with the UI they implement:
![Comparison of code for the three versions, with the UI they implement](https://github.com/JonSchwartzDev/i-ching-mithril/blob/master/iChing%20hexagram%20in%20three%20versions.png)
