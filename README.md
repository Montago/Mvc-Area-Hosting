# Mvc-Area-Hosting
Multi-Tenant Area-based MVC Hosting Site:

## The Goal:

- Host multiple websites (domains) using one host application (which enables infinite scaling !!)
- Use inheritance for Domain Modelling to access, maintain & migrate database (Code-First)
  - Optional Database-First for Tenant
  - Override / Extend ability for Tenants
- Maintain most of the MVC5 functionality for easy development
- Use Display-Templates to make page layouts and enable reusable code

#### Domain Routing
The custom domain-router translates a Domain into an Area:

eg: 

    www.AreaA.com/Controller/Action -> www.hostsite.net/AreaA/Controller/Action
    www.AreaB.com/Controller/Action -> www.hostsite.net/AreaB/Controller/Action

    www.AreaC.org/Controller/Action -> 
    www.AreaC.net/Controller/Action -> www.hostsite.net/AreaC/Controller/Action

The router relies on the PublicSuffix library which is able to dissect a hostname into all its parts and safely identify 
- Subdomain
- Domain
- TLD

And thereby route it to the correct Area. 

Subdomains will be added to the list of Tokens, making it possible to translate based on subdomain:

    en.AreaA.com -> [en] english
    dk.AreaA.com -> [dk] danish
    se.AreaA.com -> [se] swedish

## Setup:

##### IIS
Add a single Web-Application to IIS that points to the host site, but setup bindings for each domain that the application needs to host.

##### HOSTS
For testing: Add a hosts entry for each domain that the Application hosts and point to 127.0.0.1



