### Rules for Partial Class
1. All the parts spread accross different files must use the keywork partial
2. All the partial class definition must be in the same assembly and namespace
3. All the partial classes must have the same accessibility like public, private or protected.
4. If any part is declared abstract, sealed or base type. The whole class will is declared of the same type.
5. If any part is declared sealed then the whole class is declared the same type
6. If any of the parts inherites a class, then the entire type inherits the class
7. C# does not support multiple class inheritance. Different parts of the partial class, must not specify different base class
8. Different parts of the partial class can specify different base interfaces.
9. Any member that are declared in a partial definition are available to all of the other parts of the partial class.