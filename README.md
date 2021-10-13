# i-ching-aspmvc
The content for this ASP NET Core MVC web app is the 3500-year-old taoist text, which offers nicely structured data, coolly binary logic from oh so long ago, and the opportunity for very nice-looking images that are small in size.

The app works well on phones, tablets and desktop, with great, snappy interactions because the data is all local in the SPA. *Total* size in less than 220kb: 

It was bootstrapped from the dotnet template, and contains about 1000 lines of C# (mostly boilerplate), about 175 lines of CSHTML Razor pages, 175 lines of CSS and 1000 lines of content/data. This ASP MVC version uses server round trips - not a SPA, boo - but is otherwise the same functionality and design as the Mithril and React versions. I do intend to build .NET Core 6 Maui versions of this app to run natively on Android and iOS, but Maui has been delayed to perhaps April 2022. I may experiment with Blazor and/or Uno to make this version cross-platform before Maui.

See https://github.com/JonSchwartzDev/i-ching-mithril for the Mithril SPA version. 

See https://github.com/JonSchwartzDev/i-ching-react for the React SPA version.

Deploy size differences: Mithril 220kb, React webpack 800kb, ASP MVC 1200kb.

Comparison of code for the three versions, with the UI they implement:
![Comparison of code for the three versions, with the UI they implement](https://github.com/JonSchwartzDev/i-ching-mithril/blob/master/iChing%20hexagram%20in%20three%20versions.png)
