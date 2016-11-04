# DtxCS
A C# library to parse and interpret the data-driven scripting language used in Harmonix games

"DTX" is the name I've decided to use to refer to the .dta/.dtb/.dtx scripting environment that's used in most of Harmonix's games,
including the Rock Band and Guitar Hero series.

This library provides an interface to load these scripts and use them from a C# environment. Preliminary support is included for using
the scripting functionality itself.

## Supported Features
- Read data from plaintext DTA or serialized/encrypted DTB format
- Execute script commands (some builtins, such as for basic arithmetic, are included)
- Export/view plaintext DTA from root array

## Not yet supported
- True directive support (#merge, #include, #ifdef, #define, etc)
- Variables
- Function definitions / variable capture / Dynamic scoping
- Object binding / message passing system
- Re-serializing to DTB