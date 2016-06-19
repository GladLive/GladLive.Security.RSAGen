# GladLive.Security.RSAGen

RSA key generator that produces public/private and public key sets

GladLive is network session service comparable to Xboxlive or Steam. 

The GladLive.Security.RSAGen is an RSA key generator that produces:
  - Serverside Priv/Pub RSA keypair file
  - Clientside Public RSA keypair file

## GladLive Services

GladLive.ProxyLoadBalancer: https://github.com/GladLive/GladLive.ProxyLoadBalancer

GladLive.AuthenticationService: TBA

## Setup

To use this project you'll first need a couple of things:
  - Visual Studio 2015
  - A X509 cert file
  - Add Nuget Feed https://www.myget.org/F/hellokitty/api/v2 in VS (Options -> NuGet -> Package Sources)

## Instructions

Run this application with the path a the first arg to provide the path to a certificate file. Once you've provided this path it will generate the RSA keypair files for you.

Ex.

GladLive.Security.RSAGen.App.exe CertFile.pfx

If you need to generate a cert file use this: https://www.pluralsight.com/blog/software-development/selfcert-create-a-self-signed-certificate-interactively-gui-or-programmatically-in-net

## Builds

Available on a Nuget Feed: https://www.myget.org/F/hellokitty/api/v2 (N/A)

##Tests

#### Linux/Mono - Unit Tests
||Debug x86|Debug x64|Release x86|Release x64|
|:--:|:--:|:--:|:--:|:--:|:--:|
|**master**| N/A | N/A | N/A | [![Build Status](https://travis-ci.org/GladLive/GladLive.Security.RSAGen.svg?branch=master)](https://travis-ci.org/HelloKitty/GladLive/GladLive.Security.RSAGen) |
|**dev**| N/A | N/A | N/A | [![Build Status](https://travis-ci.org/GladLive/GladLive.Security.RSAGen.svg?branch=dev)](https://travis-ci.org/GladLive/GladLive.Security.RSAGen)|

#### Windows - Unit Tests

(Done locally)

##Licensing

This project is licensed under the MIT license with the additional requirement of adding the GladLive splashscreen to your product.
