# demo-api-aspnetcore-mongodb
This is a REST API sample app which demonstrate interactions with MongoDB server. The REST API is built using C#, ASP .NET Core &amp; Csharp mongodb Driver

## What you will see in the demo
When you run the sample, a HTTP server will run and host the program on port 5000. The program exposes `/api/v1/gamingPc` resource path where it returns a list of JSON objects when you browse the path or invoke it through using curl or Postman.

## Technology used for building this demo
* C# programming language.
* ASP .NET Core and Web API.
* MongoDB Driver for C#.

## What demo's parts that are not included in this repo
* The demo's data. You could grab it from here: `https://github.com/WendySanarwanto/data-for-researches/` and import it into your mongodb server.

## How to run this sample
* Ensure that you have setup .NET Core in your machine. If not, follow the instruction in here: https://www.microsoft.com/net/core#linuxubuntu
* Pull this repository into your local machine through running `git clone https://github.com/WendySanarwanto/demo-api-aspnetcore-mongodb.git` command in your CLI terminal.
* Go to inside the cloned repository's directory, then run `dotnet build -c Release` command. 
* Run `dotnet run ./bin/Release/netcoreapp1.1/demo-api-mongodb.dll` command to start the application. 
* Open your browser then browse to `http://localhost:5000/api/v1/gamingPc` path. Confirm that you will get a list of JSON objects.

## What are remanining parts that need to be done in near future ?
* The unit test, I have not done it yet.
* Creating POST, PUT , DELETE resources. I welcome for anyone whom like to work on this parts and looking forward for your pull requests.

## What are `nice to have` features that would improve the demo becoming better
* Supports for Asynchronous process on handling incoming POST, PUT, DELETE requests on API side & the mongo driver's side , using async await & Task.

## Benchmark
I benchmarked the GET resource path using `wrk` HTTP benchmarking tool (https://github.com/wg/wrk) using this command `wrk -c 256 -t 32 -d1m http://localhost:5000/api/v1/gamingpc` ( 256 connections, 32 threads, run the test for 1 minute). Here are the results:
* 1st run: Requests/sec: 1258.68. Served 75638 requests, where 495 requests were timed out and 30447 calls received as non-2xx or 3xx responses.
* 2nd run: Requests/sec: 1229.81. Served 73912 requests, where 1458 requests were timed out and 31008 calls received as non-2xx or 3xx responses
* 3rd run: Requests/sec: 1133.19. Served 68100 requests, where 437 requests were timed out and 21987 calls received as non-2xx or 3xx responses

THe machine's configuration that is used for running the benchmark are listed as follow:
* CPU: Intel i5-6600 Skylake
* RAM: 16 GB DDR 4 (2x8 GB)
* Motherboard: ASUS Z170-K Intel Z170 Chipset
* OS: Linux Ubuntu 16.04.1 LTS
* Disk: SSD 480 GB Corsair Neutron GTX
