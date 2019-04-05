#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"vs\",\"Name\":\"StateFlip\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":43,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":23}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"StateFlip\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":45,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"StateFlip\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":54,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"vs\",\"Name\":\"BasisChange\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":66,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":25}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"BasisChange\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":68,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"BasisChange\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":72,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"vs\",\"Name\":\"SignFlip\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":79,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":22}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"SignFlip\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":81,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"SignFlip\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":85,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"vs\",\"Name\":\"AmplitudeChange\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":97,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"alpha\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":44}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"AmplitudeChange\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":99,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"AmplitudeChange\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":103,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"vs\",\"Name\":\"PhaseFlip\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":110,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":23}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"PhaseFlip\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":112,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"PhaseFlip\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":116,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"vs\",\"Name\":\"PhaseChange\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":128,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"alpha\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"PhaseChange\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":130,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"PhaseChange\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":134,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"vs\",\"Name\":\"BellStateChange1\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":141,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":31}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"BellStateChange1\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":143,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"BellStateChange1\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":147,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"vs\",\"Name\":\"BellStateChange2\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":154,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":31}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"BellStateChange2\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":156,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"BellStateChange2\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":160,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"vs\",\"Name\":\"BellStateChange3\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":167,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":31}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"BellStateChange3\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":169,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"BellStateChange3\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":173,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"vs\",\"Name\":\"TwoQubitGate1\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":189,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":28}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"TwoQubitGate1\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":191,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"TwoQubitGate1\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":195,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"vs\",\"Name\":\"TwoQubitGate2\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":205,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":28}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"TwoQubitGate2\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":207,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"TwoQubitGate2\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":211,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"vs\",\"Name\":\"TwoQubitGate3\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":219,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":28}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"TwoQubitGate3\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":221,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"TwoQubitGate3\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":229,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"vs\",\"Name\":\"ToffoliGate\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":239,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":26}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"ToffoliGate\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":241,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"ToffoliGate\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":245,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"vs\",\"Name\":\"FredkinGate\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":254,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":26}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"FredkinGate\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":256,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"vs\",\"Name\":\"FredkinGate\"},\"SourceFile\":\"/Users/connor/Documents/git/quantum/vs/Tasks.qs\",\"Position\":{\"Item1\":260,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
#line hidden
namespace vs
{
    public class StateFlip : Adjointable<Qubit>, ICallable
    {
        public StateFlip(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "StateFlip";
        String ICallable.FullName => "vs.StateFlip";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<Qubit, QVoid> Body => (__in__) =>
        {
            var q = __in__;
#line 52 "/Users/connor/Documents/git/quantum/vs/Tasks.qs"
            MicrosoftQuantumPrimitiveX.Apply(q);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<Qubit, QVoid> AdjointBody => Body;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<StateFlip, Qubit, QVoid>(q);
        }
    }

    public class BasisChange : Adjointable<Qubit>, ICallable
    {
        public BasisChange(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BasisChange";
        String ICallable.FullName => "vs.BasisChange";
        public override Func<Qubit, QVoid> Body => (__in__) =>
        {
            var q = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<Qubit, QVoid> AdjointBody => Body;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<BasisChange, Qubit, QVoid>(q);
        }
    }

    public class SignFlip : Adjointable<Qubit>, ICallable
    {
        public SignFlip(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SignFlip";
        String ICallable.FullName => "vs.SignFlip";
        public override Func<Qubit, QVoid> Body => (__in__) =>
        {
            var q = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<Qubit, QVoid> AdjointBody => Body;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<SignFlip, Qubit, QVoid>(q);
        }
    }

    public class AmplitudeChange : Adjointable<(Qubit,Double)>, ICallable
    {
        public AmplitudeChange(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Double)>, IApplyData
        {
            public In((Qubit,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                }
            }
        }

        String ICallable.Name => "AmplitudeChange";
        String ICallable.FullName => "vs.AmplitudeChange";
        public override Func<(Qubit,Double), QVoid> Body => (__in__) =>
        {
            var (q,alpha) = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Double), QVoid> AdjointBody => (__in__) =>
        {
            var (q,alpha) = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Qubit,Double) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q, Double alpha)
        {
            return __m__.Run<AmplitudeChange, (Qubit,Double), QVoid>((q, alpha));
        }
    }

    public class PhaseFlip : Adjointable<Qubit>, ICallable
    {
        public PhaseFlip(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PhaseFlip";
        String ICallable.FullName => "vs.PhaseFlip";
        public override Func<Qubit, QVoid> Body => (__in__) =>
        {
            var q = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<Qubit, QVoid> AdjointBody => (__in__) =>
        {
            var q = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<PhaseFlip, Qubit, QVoid>(q);
        }
    }

    public class PhaseChange : Adjointable<(Qubit,Double)>, ICallable
    {
        public PhaseChange(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Double)>, IApplyData
        {
            public In((Qubit,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                }
            }
        }

        String ICallable.Name => "PhaseChange";
        String ICallable.FullName => "vs.PhaseChange";
        public override Func<(Qubit,Double), QVoid> Body => (__in__) =>
        {
            var (q,alpha) = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Double), QVoid> AdjointBody => (__in__) =>
        {
            var (q,alpha) = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Qubit,Double) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q, Double alpha)
        {
            return __m__.Run<PhaseChange, (Qubit,Double), QVoid>((q, alpha));
        }
    }

    public class BellStateChange1 : Adjointable<QArray<Qubit>>, ICallable
    {
        public BellStateChange1(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BellStateChange1";
        String ICallable.FullName => "vs.BellStateChange1";
        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var qs = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<BellStateChange1, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class BellStateChange2 : Adjointable<QArray<Qubit>>, ICallable
    {
        public BellStateChange2(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BellStateChange2";
        String ICallable.FullName => "vs.BellStateChange2";
        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var qs = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<BellStateChange2, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class BellStateChange3 : Adjointable<QArray<Qubit>>, ICallable
    {
        public BellStateChange3(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BellStateChange3";
        String ICallable.FullName => "vs.BellStateChange3";
        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var qs = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<BellStateChange3, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class TwoQubitGate1 : Adjointable<QArray<Qubit>>, ICallable
    {
        public TwoQubitGate1(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TwoQubitGate1";
        String ICallable.FullName => "vs.TwoQubitGate1";
        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => Body;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<TwoQubitGate1, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class TwoQubitGate2 : Adjointable<QArray<Qubit>>, ICallable
    {
        public TwoQubitGate2(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TwoQubitGate2";
        String ICallable.FullName => "vs.TwoQubitGate2";
        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => Body;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<TwoQubitGate2, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class TwoQubitGate3 : Adjointable<QArray<Qubit>>, ICallable
    {
        public TwoQubitGate3(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TwoQubitGate3";
        String ICallable.FullName => "vs.TwoQubitGate3";
        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => Body;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<TwoQubitGate3, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class ToffoliGate : Adjointable<QArray<Qubit>>, ICallable
    {
        public ToffoliGate(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ToffoliGate";
        String ICallable.FullName => "vs.ToffoliGate";
        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => Body;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<ToffoliGate, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class FredkinGate : Adjointable<QArray<Qubit>>, ICallable
    {
        public FredkinGate(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "FredkinGate";
        String ICallable.FullName => "vs.FredkinGate";
        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => Body;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<FredkinGate, QArray<Qubit>, QVoid>(qs);
        }
    }
}