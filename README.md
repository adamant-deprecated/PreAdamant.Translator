# *Deprecated* Pre-Adamant Translator

This was an attempt to create a compiler for the Pre-Adamant language as the first step of bootstrapping an Adamant compiler.  This translator tried to create a C# framework similar to the [Nanopass Framework](http://nanopass.org/) for Scheme at https://github.com/nanopass. It was planned to translate to [Swift](https://swift.org) or C++.

## Project Status: Alpha *Deprecated*

This project should not be used.

### Download and Use

Clone this git repo and compile using Visual Studio 2015.

## Reasons for Deprecation

It was found that implementing a nanopass framework capable of actually lexing and parsing text would be harder than expected.  Also, from reading more about the nanopass framework, its benefits seem to be more focused on the compiler back end.  For example, tracking errors would be difficult as one transforms the tree thereby destroying information about the original source location of things.  That is fine in the back end, but a problem in the front end.

## Explanation of this Project

The [Nanopass Framework](http://nanopass.org/) seemed to address many of the issues that have arisen in trying to bootstrap an Adamant compiler.  Benefits include:

* Not needing to create multiple trees by hand
* Being able to decouple passes
* Being able to validate the tree grammar between passes
* Automatic generation of tree traversal for nodes not modified in a passes
  
For these reasons it was thought a C# equivalent would make the process of bootstrapping a compiler much easier.  However, the nanopass framework was created assuming the input would be scheme s-expressions and would be parsed by the Scheme environment.  To address this, the C# framework was going to need to be able to apply transforms to terminal text nodes.  The plan was that these transforms would be done "in parallel" producing many alternate trees that disambiguation rules like longest match, associativity, precedence and context (i.e. enabling further matching) would then select from.  This approach would have been slower, but very flexible.  