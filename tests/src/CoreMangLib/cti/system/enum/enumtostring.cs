using System;
using System.Reflection;
using System.Reflection.Emit;
using TestLibrary;

class EnumToString
{
    static int Main()
    {
        EnumToString test = new EnumToString();

        TestFramework.BeginTestCase("Enum.ToString");

        if (test.RunTests())
        {
            TestFramework.EndTestCase();
            TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestFramework.EndTestCase();
            TestFramework.LogInformation("FAIL");
            return 0;
        }

    }

    public bool RunTests()
    {
        bool ret = true;

        ret &= PosTest1();
        ret &= PosTest2();
        ret &= PosTest3();
        ret &= PosTest4();
        ret &= PosTest5();
        ret &= PosTest6();
        ret &= PosTest7();
        ret &= PosTest8();
        ret &= PosTest9();
        ret &= PosTest10();

        ret &= PosTest11();
        ret &= PosTest12();
        ret &= PosTest13();
        ret &= PosTest14();
        ret &= PosTest15();
        ret &= PosTest16();
        ret &= PosTest17();
        ret &= PosTest18();
        ret &= PosTest19();
        ret &= PosTest20();

        ret &= PosTest21();
        ret &= PosTest22();
        ret &= PosTest23();
        ret &= PosTest24();
        ret &= PosTest25();
        ret &= PosTest26();
        ret &= PosTest27();
        ret &= PosTest28();
        ret &= PosTest29();
        ret &= PosTest30();

        ret &= PosTest31();
        ret &= PosTest32();

        ret &= NegTest1();

        return ret;
    }

    // Positive Tests

    public bool PosTest1() { return GeneralPositiveTest<TestEnumI1>(TestEnumI1.Val1, null, "Val1", "00A"); }
    public bool PosTest2() { return GeneralPositiveTest<TestEnumU1>(TestEnumU1.Val1, "", "Val1",   "00B"); }
    public bool PosTest3() { return GeneralPositiveTest<TestEnumI2>(TestEnumI2.Val1, "G", "Val1" , "00C"); }
    public bool PosTest4() { return GeneralPositiveTest<TestEnumU2>(TestEnumU2.Val1, null, "Val1", "00D"); }
    public bool PosTest5() { return GeneralPositiveTest<TestEnumI4>(TestEnumI4.Val1, null, "Val1", "00E"); }
    public bool PosTest6() { return GeneralPositiveTest<TestEnumU4>(TestEnumU4.Val1, null, "Val1", "00F"); }
    public bool PosTest7() { return GeneralPositiveTest<TestEnumI8>(TestEnumI8.Val1, null, "Val1", "00G"); }
    public bool PosTest8() { return GeneralPositiveTest<TestEnumU8>(TestEnumU8.Val1, null, "Val1", "00H"); }

    public bool PosTest9() { return GeneralPositiveTest<TestEnumI1>(TestEnumI1.Val1, "D", "1", "00I"); }
    public bool PosTest10() { return GeneralPositiveTest<TestEnumU1>(TestEnumU1.Val1, "D", "1", "00J"); }
    public bool PosTest11() { return GeneralPositiveTest<TestEnumI2>(TestEnumI2.Val1, "D", "1", "00K"); }
    public bool PosTest12() { return GeneralPositiveTest<TestEnumU2>(TestEnumU2.Val1, "D", "1", "00L"); }
    public bool PosTest13() { return GeneralPositiveTest<TestEnumI4>(TestEnumI4.Val1, "D", "1", "00M"); }
    public bool PosTest14() { return GeneralPositiveTest<TestEnumU4>(TestEnumU4.Val1, "D", "1", "00N"); }
    public bool PosTest15() { return GeneralPositiveTest<TestEnumI8>(TestEnumI8.Val1, "D", "1", "00O"); }
    public bool PosTest16() { return GeneralPositiveTest<TestEnumU8>(TestEnumU8.Val1, "D", "1", "00P"); }

    public bool PosTest17() { return GeneralPositiveTest<TestEnumI1>(TestEnumI1.Val1, "X", "01", "00Q"); }
    public bool PosTest18() { return GeneralPositiveTest<TestEnumU1>(TestEnumU1.Val1, "X", "01", "00R"); }
    public bool PosTest19() { return GeneralPositiveTest<TestEnumI2>(TestEnumI2.Val1, "X", "0001", "00S"); }
    public bool PosTest20() { return GeneralPositiveTest<TestEnumU2>(TestEnumU2.Val1, "X", "0001", "00T"); }
    public bool PosTest21() { return GeneralPositiveTest<TestEnumI4>(TestEnumI4.Val1, "X", "00000001", "00U"); }
    public bool PosTest22() { return GeneralPositiveTest<TestEnumU4>(TestEnumU4.Val1, "X", "00000001", "00V"); }
    public bool PosTest23() { return GeneralPositiveTest<TestEnumI8>(TestEnumI8.Val1, "X", "0000000000000001", "00W"); }
    public bool PosTest24() { return GeneralPositiveTest<TestEnumU8>(TestEnumU8.Val1, "X", "0000000000000001", "00X"); }

    public bool PosTest25() { return GeneralPositiveTest<TestEnumI1>(TestEnumI1.Val1, "F", "Val1", "00Y"); }
    public bool PosTest26() { return GeneralPositiveTest<TestEnumU1>(TestEnumU1.Val1, "F", "Val1", "00Z"); }
    public bool PosTest27() { return GeneralPositiveTest<TestEnumI2>(TestEnumI2.Val1, "F", "Val1", "0AA"); }
    public bool PosTest28() { return GeneralPositiveTest<TestEnumU2>(TestEnumU2.Val1, "F", "Val1", "0AB"); }
    public bool PosTest29() { return GeneralPositiveTest<TestEnumI4>(TestEnumI4.Val1, "F", "Val1", "0AC"); }
    public bool PosTest30() { return GeneralPositiveTest<TestEnumU4>(TestEnumU4.Val1, "F", "Val1", "0AD"); }
    public bool PosTest31() { return GeneralPositiveTest<TestEnumI8>(TestEnumI8.Val1, "F", "Val1", "0AE"); }
    public bool PosTest32() { return GeneralPositiveTest<TestEnumU8>(TestEnumU8.Val1, "F", "Val1", "0AF"); }

    public bool NegTest1()
    {
        string id = "0AG";
        bool result = true;

        TestFramework.BeginScenario(id + ": Testing Enum.ToString");
        try
        {
            string output = TestEnumU4.Val1.ToString("L");
                result = false;
                TestFramework.LogError("001", "Expected exception not thrown in " + id);
        }
        catch (Exception exc)
        {
            if (exc.GetType() != typeof(FormatException))
            {
                result = false;
                TestFramework.LogError("003", "Unexpected exception in " + id + ", excpetion: " + exc.ToString());
            }
        }
        return result;
    }

    public bool GeneralPositiveTest<T>(T input, string format, string expected, string id)
    {
        bool result = true;

        TestFramework.BeginScenario(id + ": Testing Enum.ToString");
        try
        {
            string output = (input as Enum).ToString(format);
            
            if (output != expected)
            {
                result = false;
                TestFramework.LogError("001", "ToString not correct in " + id + ". Expected: " + expected + "; Actual: " + output);
            }
        }
        catch (Exception exc)
        {
            result = false;
            TestFramework.LogError("003", "Unexpected exception in " + id + ", excpetion: " + exc.ToString());
        }
        return result;
    }
}

enum TestEnumI1: sbyte
{
    Val1 = 1,
    Val2 = 2
}

enum TestEnumU1 : byte
{
    Val1 = 1,
    Val2 = 2
}

enum TestEnumI2 : short
{
    Val1 = 1,
    Val2 = 2
}

enum TestEnumU2 : ushort
{
    Val1 = 1,
    Val2 = 2
}

enum TestEnumI4 : int
{
    Val1 = 1,
    Val2 = 2
}

enum TestEnumU4 : uint
{
    Val1 = 1,
    Val2 = 2
}

enum TestEnumI8 : long
{
    Val1 = 1,
    Val2 = 2
}

enum TestEnumU8 : ulong
{
    Val1 = 1,
    Val2 = 2
}