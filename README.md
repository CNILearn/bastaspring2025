# BASTA! Spring 2025

Frankfurt, 3.-7. März 2025

[BASTA! Die Konferenz für .NET, Web & AI Innovation](https://basta.net/frankfurt)

## Important links

- [My C# Blog](https://csharp.christiannagel.com)
- [Codebreaker Org](https://github.com/codebreakerapp)
- [Pragmatic Microservices Book Repo](https://github.com/PacktPublishing/Pragmatic-Microservices-With-csharp-and-Azure)
- [Pragmatic Microservices Book](https://www.packtpub.com/en-us/product/pragmatic-microservices-with-c-and-azure-9781835088296)
- [Upcoming Expert C# Book Repo](https://github.com/PacktPublishing/Expert-CSharp-Programming)

## C# 13: Neue Funktionen und Ausblick auf C# 14

Dienstag, 4. März 2025 - 10:45-11:45, Gold 2

C# 13 ist da! Obwohl die Liste der neuen Features kürzer ist als in früheren Versionen, gibt es spannende Neuerungen zu entdecken. Unter anderem wurde das lock-Keyword für den neuen .NET 9 Typ Lock überarbeitet. Außerdem ist es jetzt nicht mehr notwendig, eine variable Anzahl von Parametern ausschließlich mit einem Array zu deklarieren – Span ist eine der neuen Optionen! Zudem gibt es zahlreiche Erweiterungen für ref struct-Typen. In dieser Session erfahren Sie alles über die neuen Erweiterungen von C#, die Weiterentwicklung der Sprache und die Vorteile, die diese Features mit sich bringen.

[Slides C# 13 and 14 Updates](slides/CSharpUpdates.pdf)

### Samples

- Escape character (C# 13)
- Implicit index access with object initializers (C# 13)
- Simple lambda expression parameters with modifiers (C# 14)
- Unconstrained generics (C# 14)
- Natural types
- Enhancements with method groups and natural types (C# 14)
- Field keyword (C# 13 with preview)
- Weak events, partial events (C# 14)
- Books App using Aspire, WPF, WinUI with Community Toolkit (Field keyword, partial properties)
- Ref struct with interface implementations, allows ref struct
- Allows ref struct
- Params with IEnumerable, List, Span (C# 13)
- Span conversion (C# 14)
- Lock (C# 13)
- Native AOT 

[Expert C# Book Repo](https://github.com/PacktPublishing/Expert-CSharp-Programming)

## Von Transient zu Singleton: die Geheimnisse der .NET Dependency Injection

Mittwoch, 5. März 2025 - 10:30 - 11:30, Ballsaal 2

In dieser Session tauchen wir in die Welt der .NET Dependency Injection ein und beleuchten die entscheidenden Unterschiede zwischen den Lebenszyklen von Transient, Scoped und Singleton. Wir werden die Implementierung von generischen Services untersuchen und die besten Praktiken für das Dispose-Management diskutieren, um Ressourcen effizient zu verwalten. Zudem werfen wir einen Blick auf Keyed Services und deren Anwendung in komplexen Architekturen. Diese Session richtet sich an Entwickler, die ihre Kenntnisse in Dependency Injection vertiefen und lernen möchten, wie sie robuste, wartbare und skalierbare Anwendungen erstellen können.

[DI Container](slides/DIContainer.pdf)

[Pragmatic Microservices with C# and Azure Book Repo](https://github.com/PacktPublishing/Pragmatic-Microservices-with-CSharp-and-Azure)

### Samples

- Dependency Injection
- Using Microsoft.Extensions.DependencyInjection
- Using Host
- Using Host with App Builder Pattern
- Configuration and Logging
- Background Worker
- Windows Services
- ASP.NET Core MVC
- Blazor Web App
- Blazor with Auto Rendering and two DI containers
- Windows Desktop with platform independence
- Lifetime
- Override
- Collections of services
- Keyed services
- Generics

## Workshop: .NET Aspire mit .NET 9 und Microsoft Azure

Freitag, 7. März 2025 - 09:00 - 16:30, Gigabyte WS

Erleben Sie die Zukunft der Anwendungsentwicklung mit .NET Aspire, einem Cloud-fähigen Stack aus Bibliotheken und Tools zur Entwicklung verteilter Anwendungen. 

In diesem Workshop starten wir mit der Erstellung von ASP.NET Core APIs und integrieren diese nahtlos in eine Clientanwendung mit dem .NET Aspire App Model.

- Einführung in .NET Aspire: Überblick über die wichtigsten Komponenten und Funktionen
- Entwicklung von ASP.NET Core APIs: Schritt-für-Schritt-Anleitung zur Erstellung und Implementierung
- Integration mit Clientanwendungen: Nutzung des .NET Aspire App Models für eine reibungslose Integration
- Datenpersistenz mit Aspire Integrations: Einbindung einer Datenbank zur dauerhaften Speicherung von Daten
- Deployment in die Cloud: Nutzung des Azure Developer CLI und Aspire Manifests zur Bereitstellung der Services in Microsoft Azure
- On-Premises Hosting: Alternative Bereitstellung der Services in einem Kubernetes-Cluster.
- Monitoring und Fehlerbehebung: Einsatz von Monitoring-Features zur Überwachung der Funktionalität und Identifikation von Problemen
  
Am Ende des Workshops nehmen Sie eine vollständige .NET-Aspire-Lösung mit, die lokal und in der Cloud läuft. Nutzen Sie diese Gelegenheit, um Ihre Fähigkeiten zu erweitern und die neuesten Technologien von Microsoft kennenzulernen.
