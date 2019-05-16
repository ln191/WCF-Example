# WCF-Example

https://www.codeproject.com/Articles/406096/A-beginners-tutorial-for-understanding-Windows

The following table illustrates the differences between a web service and a WCF service:

Web Service									WCF Service
Communication can happen over HTTP only.					Communication can happen over HTTP, TCP, IPC, or even MSMQ.
Only simplex and request-response communication is possible			It can be configured to have simplex, request-response, or even full duplex communication.
Work in an stateless fashion over HTTP, hosted inside a web server like IIS.	These can be hosted in many ways inside IIS, inside a Windows service, or even self hosted.

Note: Apart from these differences, there are other differences related to instance management, sessions, and data representation and serialization. We will not discuss these here as they tend to be digressing for beginners.