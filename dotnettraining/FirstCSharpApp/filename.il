
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly FirstCSharpApp
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 0E 46 69 72 73 74 43 53 68 61 72 70 41 70   // ...FirstCSharpAp
                                                                                              70 00 00 )                                        // p..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 0E 46 69 72 73 74 43 53 68 61 72 70 41 70   // ...FirstCSharpAp
                                                                                                70 00 00 )                                        // p..
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                  20 32 30 31 35 00 00 )                            //  2015..
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 64 65 30 35 32 35 35 30 2D 36 66 38 36   // ..$de052550-6f86
                                                                                                  2D 34 62 35 31 2D 39 36 39 64 2D 31 33 30 35 61   // -4b51-969d-1305a
                                                                                                  36 39 62 36 36 33 62 00 00 )                      // 69b663b..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 31 2E 30 2E 30 00 00 )             // ...1.1.0.0..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1A 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 35 01 00 54   // ,Version=v4.5..T
                                                                                                        0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C   // ..FrameworkDispl
                                                                                                        61 79 4E 61 6D 65 12 2E 4E 45 54 20 46 72 61 6D   // ayName..NET Fram
                                                                                                        65 77 6F 72 6B 20 34 2E 35 )                      // ework 4.5
  .permissionset reqmin
             = {[mscorlib]System.Security.Permissions.SecurityPermissionAttribute = {property bool 'SkipVerification' = bool(true)}}
  .hash algorithm 0x00008004
  .ver 1:1:0:0
}
.module FirstCSharpApp.exe
// MVID: {7EBFC522-43B7-4441-8F93-14986FE25BE6}
.custom instance void [mscorlib]System.Security.UnverifiableCodeAttribute::.ctor() = ( 01 00 00 00 ) 
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED
// Image base: 0x09470000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit FirstCSharpApp.Program
       extends [mscorlib]System.Object
{
  .class auto ansi sealed nested private Menu
         extends [mscorlib]System.Enum
  {
    .field public specialname rtspecialname int32 value__
    .field public static literal valuetype FirstCSharpApp.Program/Menu Option1 = int32(0x00000000)
    .field public static literal valuetype FirstCSharpApp.Program/Menu Option2 = int32(0x00000001)
    .field public static literal valuetype FirstCSharpApp.Program/Menu Option3 = int32(0x00000002)
  } // end of class Menu

  .field private static string '<AppName>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggerBrowsableState) = ( 01 00 00 00 00 00 00 00 ) 
  .field private static int32 number
  .field private static string name
  .field private static string[] arrMenu
  .field private static int32 i
  .field private static valuetype FirstCSharpApp.Program/Menu m
  .method public hidebysig specialname static 
          string  get_AppName() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       6 (0x6)
    .maxstack  8
    IL_0000:  ldsfld     string FirstCSharpApp.Program::'<AppName>k__BackingField'
    IL_0005:  ret
  } // end of method Program::get_AppName

  .method public hidebysig specialname static 
          void  set_AppName(string 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  stsfld     string FirstCSharpApp.Program::'<AppName>k__BackingField'
    IL_0006:  ret
  } // end of method Program::set_AppName

  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       448 (0x1c0)
    .maxstack  4
    .locals init ([0] string readline,
             [1] int32 read,
             [2] valuetype [mscorlib]System.ConsoleKeyInfo readkey,
             [3] valuetype FirstCSharpApp.Program/Menu myMenu,
             [4] string callResult,
             [5] string userData,
             [6] bool isDataValid,
             [7] int32 result,
             [8] valuetype FirstCSharpApp.Program/Menu V_8,
             [9] valuetype FirstCSharpApp.Program/Menu V_9,
             [10] string[] V_10,
             [11] int32 V_11,
             [12] string item,
             [13] bool V_13)
    IL_0000:  nop
    IL_0001:  ldc.i4.0
    IL_0002:  stsfld     valuetype FirstCSharpApp.Program/Menu FirstCSharpApp.Program::m
    IL_0007:  ldstr      "Integer value: {0} = {1} + {2}"
    IL_000c:  ldsfld     int32 FirstCSharpApp.Program::number
    IL_0011:  box        [mscorlib]System.Int32
    IL_0016:  ldc.i4     0x3e8
    IL_001b:  box        [mscorlib]System.Int32
    IL_0020:  ldc.i4.s   30
    IL_0022:  box        [mscorlib]System.Int32
    IL_0027:  call       void [mscorlib]System.Console::WriteLine(string,
                                                                  object,
                                                                  object,
                                                                  object)
    IL_002c:  nop
    IL_002d:  ldstr      "String value: We are a part of {0} "
    IL_0032:  ldsfld     string FirstCSharpApp.Program::name
    IL_0037:  call       void [mscorlib]System.Console::WriteLine(string,
                                                                  object)
    IL_003c:  nop
    IL_003d:  ldstr      "Value of Enum is: {0}"
    IL_0042:  ldsfld     valuetype FirstCSharpApp.Program/Menu FirstCSharpApp.Program::m
    IL_0047:  box        FirstCSharpApp.Program/Menu
    IL_004c:  call       void [mscorlib]System.Console::WriteLine(string,
                                                                  object)
    IL_0051:  nop
    IL_0052:  call       string [mscorlib]System.Console::ReadLine()
    IL_0057:  stloc.0
    IL_0058:  ldstr      "Value entered by user: {0}"
    IL_005d:  ldloc.0
    IL_005e:  call       void [mscorlib]System.Console::WriteLine(string,
                                                                  object)
    IL_0063:  nop
    IL_0064:  call       int32 [mscorlib]System.Console::Read()
    IL_0069:  stloc.1
    IL_006a:  ldstr      "Value entered by user: {0}"
    IL_006f:  ldloc.1
    IL_0070:  box        [mscorlib]System.Int32
    IL_0075:  call       void [mscorlib]System.Console::WriteLine(string,
                                                                  object)
    IL_007a:  nop
    IL_007b:  call       valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
    IL_0080:  stloc.2
    IL_0081:  ldstr      "Value entered by user: {0}"
    IL_0086:  ldloca.s   readkey
    IL_0088:  call       instance char [mscorlib]System.ConsoleKeyInfo::get_KeyChar()
    IL_008d:  box        [mscorlib]System.Char
    IL_0092:  call       void [mscorlib]System.Console::WriteLine(string,
                                                                  object)
    IL_0097:  nop
    IL_0098:  call       string [mscorlib]System.Console::ReadLine()
    IL_009d:  call       void FirstCSharpApp.Program::set_AppName(string)
    IL_00a2:  nop
    IL_00a3:  ldstr      "Value in AppName: {0}"
    IL_00a8:  call       string FirstCSharpApp.Program::get_AppName()
    IL_00ad:  call       void [mscorlib]System.Console::WriteLine(string,
                                                                  object)
    IL_00b2:  nop
    IL_00b3:  ldstr      "Enter an option .... "
    IL_00b8:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_00bd:  nop
    IL_00be:  ldtoken    FirstCSharpApp.Program/Menu
    IL_00c3:  call       class [mscorlib]System.Type [mscorlib]System.Type::GetTypeFromHandle(valuetype [mscorlib]System.RuntimeTypeHandle)
    IL_00c8:  call       string [mscorlib]System.Console::ReadLine()
    IL_00cd:  call       object [mscorlib]System.Enum::Parse(class [mscorlib]System.Type,
                                                             string)
    IL_00d2:  unbox.any  FirstCSharpApp.Program/Menu
    IL_00d7:  stloc.3
    IL_00d8:  ldloc.3
    IL_00d9:  stloc.s    V_9
    IL_00db:  ldloc.s    V_9
    IL_00dd:  stloc.s    V_8
    IL_00df:  ldloc.s    V_8
    IL_00e1:  switch     ( 
                          IL_00f4,
                          IL_0137,
                          IL_0139)
    IL_00f2:  br.s       IL_013b

    IL_00f4:  ldstr      "Option 1 Group consists of the following members"
    IL_00f9:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_00fe:  nop
    IL_00ff:  nop
    IL_0100:  ldsfld     string[] FirstCSharpApp.Program::arrMenu
    IL_0105:  stloc.s    V_10
    IL_0107:  ldc.i4.0
    IL_0108:  stloc.s    V_11
    IL_010a:  br.s       IL_012d

    IL_010c:  ldloc.s    V_10
    IL_010e:  ldloc.s    V_11
    IL_0110:  ldelem.ref
    IL_0111:  stloc.s    item
    IL_0113:  nop
    IL_0114:  ldstr      "# "
    IL_0119:  ldloc.s    item
    IL_011b:  call       string [mscorlib]System.String::Concat(string,
                                                                string)
    IL_0120:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0125:  nop
    IL_0126:  nop
    IL_0127:  ldloc.s    V_11
    IL_0129:  ldc.i4.1
    IL_012a:  add
    IL_012b:  stloc.s    V_11
    IL_012d:  ldloc.s    V_11
    IL_012f:  ldloc.s    V_10
    IL_0131:  ldlen
    IL_0132:  conv.i4
    IL_0133:  blt.s      IL_010c

    IL_0135:  br.s       IL_013d

    IL_0137:  br.s       IL_013d

    IL_0139:  br.s       IL_013d

    IL_013b:  br.s       IL_013d

    IL_013d:  ldstr      "This is to output a single string"
    IL_0142:  call       void [mscorlib]System.Console::Write(string)
    IL_0147:  nop
    IL_0148:  ldstr      "This is to output a line of data"
    IL_014d:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0152:  nop
    IL_0153:  ldstr      "Pratibha"
    IL_0158:  call       string FirstCSharpApp.Program::SayHello(string)
    IL_015d:  stloc.s    callResult
    IL_015f:  ldloc.s    callResult
    IL_0161:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0166:  nop
    IL_0167:  call       valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
    IL_016c:  pop
    IL_016d:  ldstr      "##### Interpreting user data ######"
    IL_0172:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0177:  nop
    IL_0178:  call       string FirstCSharpApp.Program::ReadUserData()
    IL_017d:  stloc.s    userData
    IL_017f:  ldloc.s    userData
    IL_0181:  call       bool FirstCSharpApp.Program::IsUserDataValid(string)
    IL_0186:  stloc.s    isDataValid
    IL_0188:  ldloc.s    isDataValid
    IL_018a:  stloc.s    V_13
    IL_018c:  ldloc.s    V_13
    IL_018e:  brfalse.s  IL_019f

    IL_0190:  nop
    IL_0191:  ldstr      "Entered Data is valid"
    IL_0196:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_019b:  nop
    IL_019c:  nop
    IL_019d:  br.s       IL_01ac

    IL_019f:  nop
    IL_01a0:  ldstr      "Entered Data is invalid"
    IL_01a5:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_01aa:  nop
    IL_01ab:  nop
    IL_01ac:  call       int32 FirstCSharpApp.Program::SwitchCaseExample()
    IL_01b1:  stloc.s    result
    IL_01b3:  call       void FirstCSharpApp.Program::CallSwitchCaseInLoop()
    IL_01b8:  nop
    IL_01b9:  call       valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
    IL_01be:  pop
    IL_01bf:  ret
  } // end of method Program::Main

  .method private hidebysig static string 
          SayHello(string pName) cil managed
  {
    // Code size       19 (0x13)
    .maxstack  2
    .locals init ([0] string result,
             [1] string V_1)
    IL_0000:  nop
    IL_0001:  ldstr      "Hello "
    IL_0006:  ldarg.0
    IL_0007:  call       string [mscorlib]System.String::Concat(string,
                                                                string)
    IL_000c:  stloc.0
    IL_000d:  ldloc.0
    IL_000e:  stloc.1
    IL_000f:  br.s       IL_0011

    IL_0011:  ldloc.1
    IL_0012:  ret
  } // end of method Program::SayHello

  .method private hidebysig static string 
          ReadUserData() cil managed
  {
    // Code size       13 (0xd)
    .maxstack  1
    .locals init ([0] string result,
             [1] string V_1)
    IL_0000:  nop
    IL_0001:  call       string [mscorlib]System.Console::ReadLine()
    IL_0006:  stloc.0
    IL_0007:  ldloc.0
    IL_0008:  stloc.1
    IL_0009:  br.s       IL_000b

    IL_000b:  ldloc.1
    IL_000c:  ret
  } // end of method Program::ReadUserData

  .method private hidebysig static bool  IsUserDataValid(string pData) cil managed
  {
    // Code size       28 (0x1c)
    .maxstack  2
    .locals init ([0] bool V_0,
             [1] bool V_1)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldstr      "Yes"
    IL_0007:  call       bool [mscorlib]System.String::op_Equality(string,
                                                                   string)
    IL_000c:  stloc.0
    IL_000d:  ldloc.0
    IL_000e:  brfalse.s  IL_0015

    IL_0010:  nop
    IL_0011:  ldc.i4.1
    IL_0012:  stloc.1
    IL_0013:  br.s       IL_001a

    IL_0015:  nop
    IL_0016:  ldc.i4.0
    IL_0017:  stloc.1
    IL_0018:  br.s       IL_001a

    IL_001a:  ldloc.1
    IL_001b:  ret
  } // end of method Program::IsUserDataValid

  .method private hidebysig static int32 
          SwitchCaseExample() cil managed
  {
    // Code size       165 (0xa5)
    .maxstack  2
    .locals init ([0] string operationType,
             [1] int32 num1,
             [2] int32 num2,
             [3] int32 result,
             [4] string V_4,
             [5] string V_5,
             [6] int32 V_6)
    IL_0000:  nop
    IL_0001:  ldstr      "Select operation: /nAdd /nSub /nMul /nDiv "
    IL_0006:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000b:  nop
    IL_000c:  call       string [mscorlib]System.Console::ReadLine()
    IL_0011:  stloc.0
    IL_0012:  ldstr      "Enter a number"
    IL_0017:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_001c:  nop
    IL_001d:  call       string [mscorlib]System.Console::ReadLine()
    IL_0022:  call       int16 [mscorlib]System.Convert::ToInt16(string)
    IL_0027:  stloc.1
    IL_0028:  ldstr      "Enter a number"
    IL_002d:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0032:  nop
    IL_0033:  call       string [mscorlib]System.Console::ReadLine()
    IL_0038:  call       int16 [mscorlib]System.Convert::ToInt16(string)
    IL_003d:  stloc.2
    IL_003e:  ldc.i4.0
    IL_003f:  stloc.3
    IL_0040:  ldloc.0
    IL_0041:  stloc.s    V_5
    IL_0043:  ldloc.s    V_5
    IL_0045:  stloc.s    V_4
    IL_0047:  ldloc.s    V_4
    IL_0049:  ldstr      "Add"
    IL_004e:  call       bool [mscorlib]System.String::op_Equality(string,
                                                                   string)
    IL_0053:  brtrue.s   IL_0081

    IL_0055:  ldloc.s    V_4
    IL_0057:  ldstr      "Sub"
    IL_005c:  call       bool [mscorlib]System.String::op_Equality(string,
                                                                   string)
    IL_0061:  brtrue.s   IL_0087

    IL_0063:  ldloc.s    V_4
    IL_0065:  ldstr      "Mul"
    IL_006a:  call       bool [mscorlib]System.String::op_Equality(string,
                                                                   string)
    IL_006f:  brtrue.s   IL_008d

    IL_0071:  ldloc.s    V_4
    IL_0073:  ldstr      "Div"
    IL_0078:  call       bool [mscorlib]System.String::op_Equality(string,
                                                                   string)
    IL_007d:  brtrue.s   IL_0094

    IL_007f:  br.s       IL_009b

    IL_0081:  ldloc.1
    IL_0082:  ldloc.2
    IL_0083:  add
    IL_0084:  stloc.3
    IL_0085:  br.s       IL_009d

    IL_0087:  ldloc.1
    IL_0088:  ldloc.2
    IL_0089:  sub
    IL_008a:  stloc.3
    IL_008b:  br.s       IL_009d

    IL_008d:  ldloc.1
    IL_008e:  ldloc.2
    IL_008f:  mul
    IL_0090:  stloc.s    V_6
    IL_0092:  br.s       IL_00a2

    IL_0094:  ldloc.1
    IL_0095:  ldloc.2
    IL_0096:  div
    IL_0097:  stloc.s    V_6
    IL_0099:  br.s       IL_00a2

    IL_009b:  br.s       IL_009d

    IL_009d:  ldloc.3
    IL_009e:  stloc.s    V_6
    IL_00a0:  br.s       IL_00a2

    IL_00a2:  ldloc.s    V_6
    IL_00a4:  ret
  } // end of method Program::SwitchCaseExample

  .method private hidebysig static void  CallSwitchCaseInLoop() cil managed
  {
    // Code size       65 (0x41)
    .maxstack  2
    .locals init ([0] string isContinue,
             [1] int32 result,
             [2] bool V_2)
    IL_0000:  nop
    IL_0001:  nop
    IL_0002:  call       int32 FirstCSharpApp.Program::SwitchCaseExample()
    IL_0007:  stloc.1
    IL_0008:  ldstr      "Answer: "
    IL_000d:  ldloca.s   result
    IL_000f:  call       instance string [mscorlib]System.Int32::ToString()
    IL_0014:  call       string [mscorlib]System.String::Concat(string,
                                                                string)
    IL_0019:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_001e:  nop
    IL_001f:  ldstr      "Do you want to continue\? Y/N"
    IL_0024:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0029:  nop
    IL_002a:  call       string [mscorlib]System.Console::ReadLine()
    IL_002f:  stloc.0
    IL_0030:  nop
    IL_0031:  ldloc.0
    IL_0032:  ldstr      "Y"
    IL_0037:  call       bool [mscorlib]System.String::op_Equality(string,
                                                                   string)
    IL_003c:  stloc.2
    IL_003d:  ldloc.2
    IL_003e:  brtrue.s   IL_0001

    IL_0040:  ret
  } // end of method Program::CallSwitchCaseInLoop

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Program::.ctor

  .method private hidebysig specialname rtspecialname static 
          void  .cctor() cil managed
  {
    // Code size       56 (0x38)
    .maxstack  8
    IL_0000:  ldc.i4     0x406
    IL_0005:  stsfld     int32 FirstCSharpApp.Program::number
    IL_000a:  ldstr      "Nitor .Net Group"
    IL_000f:  stsfld     string FirstCSharpApp.Program::name
    IL_0014:  ldc.i4.3
    IL_0015:  newarr     [mscorlib]System.String
    IL_001a:  dup
    IL_001b:  ldc.i4.0
    IL_001c:  ldstr      "Seema"
    IL_0021:  stelem.ref
    IL_0022:  dup
    IL_0023:  ldc.i4.1
    IL_0024:  ldstr      "Reema"
    IL_0029:  stelem.ref
    IL_002a:  dup
    IL_002b:  ldc.i4.2
    IL_002c:  ldstr      "Neema"
    IL_0031:  stelem.ref
    IL_0032:  stsfld     string[] FirstCSharpApp.Program::arrMenu
    IL_0037:  ret
  } // end of method Program::.cctor

  .property string AppName()
  {
    .get string FirstCSharpApp.Program::get_AppName()
    .set void FirstCSharpApp.Program::set_AppName(string)
  } // end of property Program::AppName
} // end of class FirstCSharpApp.Program

.class private auto ansi beforefieldinit ForRealtimeDemos.MyFirstDemo.MyFunnyProgram
       extends [mscorlib]System.Object
{
  .field private int32 num
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method MyFunnyProgram::.ctor

} // end of class ForRealtimeDemos.MyFirstDemo.MyFunnyProgram


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file D:\FirstCSharpApp\filename.res
