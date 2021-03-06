﻿namespace WebSharper.MathJS.Extensions

open WebSharper
open WebSharper.JavaScript
open WebSharper.MathJS
open System.Numerics

[<Require(typeof<WebSharper.MathJS.Resources.Js>)>]    
module internal Extensions =
    
    [<Proxy(typeof<System.Numerics.Complex>)>]
    type ComplexProxy =

        [<Inline "math.complex($r, $i)">]
        new (r : float, i : float) = {}

        member this.Imaginary
            with [<Inline "$this.im">] get () = X<float>

        //member this.Magnitude
        //    with [<Inline>] get () = Math.Abs(this)

        member this.Magnitude
            with [<Inline "math.abs($this)">] get () = X<float>

        member this.Phase
            with [<Inline "math.atan2($this.im, $this.re)">] get () = X<float>

        member this.Real
            with [<Inline "$this.re">] get () = X<float>

        [<Inline "math.abs($c)">]
        static member Abs(c : Complex) = X<float>

        [<Inline "math.acos($c)">]
        static member Acos(c : Complex) = X<Complex>

        [<Inline "math.add($c1, $c2)">]
        static member Add(c1 : Complex, c2 : Complex) = X<Complex>

        [<Inline "math.asin($c)">]
        static member Asin(c : Complex) = X<Complex>

        [<Inline "math.atan($c)">]
        static member Atan(c : Complex) = X<Complex>

        [<Inline "math.conj($c)">]
        static member Conjugate(c : Complex) = X<Complex>

        [<Inline "math.cos($c)">]
        static member Cos(c : Complex) = X<Complex>

        [<Inline "math.cosh($c)">]
        static member Cosh(c : Complex) = X<Complex>

        [<Inline "math.divide($c1, $c2)">]
        static member Divide(c1 : Complex, c2 : Complex) = X<Complex>

        [<Inline "$this.equals($c)">]
        static member Equals(c : Complex) = X<bool>

        [<Inline "math.exp(c)">]
        static member Exp(c : Complex) = X<Complex>

        [<Inline "math.complex.fromPolar($r, $i)">]
        static member FromPolarCoordinates(r : float, i : float) = X<Complex>

        [<Inline "math.log($c)">]
        static member Log(c : Complex) = X<Complex>

        [<Inline "math.log($c, $b)">]
        static member Log(c : Complex, b : float) = X<Complex>

        [<Inline "math.log10($c)">]
        static member Log10(c : Complex) = X<Complex>

        [<Inline "math.multiply($c1, $c2)">]
        static member Multiply(c1 : Complex, c2 : Complex) = X<Complex>

        [<Inline "math.unaryMinus($c)">]
        static member Negate(c : Complex) = X<Complex>

        [<Inline "math.pow($c1, $c2)">]
        static member Pow(c1 : Complex, c2 : Complex) = X<Complex>

        [<Inline "math.pow($c, $d)">]
        static member Pow(c : Complex, d : float) = X<Complex>

        [<Inline "math.sin($c)">]
        static member Sin(c : Complex) = X<Complex>

        [<Inline "math.sinh($c)">]
        static member Sinh(c : Complex) = X<Complex>

        [<Inline "math.sqrt($c)">]
        static member Sqrt(c : Complex) = X<Complex>

        [<Inline "math.subtract($c1, $c2)">]
        static member Subtract(c1 : Complex, c2 : Complex) = X<Complex>

        [<Inline "math.tan($c)">]
        static member Tan(c : Complex) = X<Complex>

        [<Inline "math.tanh($c)">]
        static member Tanh(c : Complex) = X<Complex>

        [<Inline "$this.toString()">]
        static member ToString() = X<string>

        [<Inline "$this.format($n)">]
        member x.ToString(n : string) = X<string>

        [<Inline "math.complex(0, 1)">]
        static member ImaginaryOne = X<Complex>

        [<Inline "math.complex(1, 0)">]
        static member One = X<Complex>

        [<Inline "math.complex(0, 0)">]
        static member Zero = X<Complex>

        [<Inline "math.add($c1, $c2)">]
        static member op_Addition(c1 : Complex, c2 : Complex) = X<Complex>

        [<Inline "math.divide($c1, $c2)">]
        static member op_Division(c1 : Complex, c2 : Complex) = X<Complex>

        [<Inline "$c1.equals($c2)">]
        static member op_Equality(c1 : Complex, c2 : Complex) = X<bool>

        [<Inline "math.complex($i)">]
        static member op_Explicit(i : bigint) = X<Complex>

        [<Inline "!$c1.equals($c2)">]
        static member op_Inequality(c1 : Complex, c2 : Complex) = X<bool>

        [<Inline "math.multiply($c1, $c2)">]
        static member op_Multiply(c1 : Complex, c2 : Complex) = X<Complex>

        [<Inline "math.subtract($c1, $c2)">]
        static member op_Subtraction(c1 : Complex, c2 : Complex) = X<Complex>

        [<Inline "math.unaryMinus($c)">]
        static member op_UnaryNegation(c : Complex) = X<Complex>

    [<Proxy(typeof<System.Numerics.BigInteger>)>]
    type BigIntegerProxy =

        [<Inline "math.bignumber($v)">]
        new (v : byte[]) = {}

        [<Inline "math.bignumber($v)">]
        new (v : decimal) = {}

        [<Inline "math.bignumber($v)">]
        new (v : double) = {}

        [<Inline "math.bignumber($v)">]
        new (v : int32) = {}

        [<Inline "math.bignumber($v)">]
        new (v : int64) = {}

        [<Inline "math.bignumber($v)">]
        new (v : single) = {}

        [<Inline "math.bignumber($v)">]
        new (v : uint32) = {}

        [<Inline "math.bignumber($v)">]
        new (v : uint64) = {}

        [<Inline "math.abs($n)">]
        static member Abs(n : bigint) = X<bigint>

        [<Inline "math.add($n1, $n2)">]
        static member Add(n1 : bigint, n2 : bigint) = X<bigint>

        [<Inline "math.compare($n1, $n2)">]
        static member Compare(n1 : bigint, n2 : bigint) = X<int>

        [<Inline "math.compare($this, $n)">]
        static member CompareTo(n : bigint) = X<int>

        [<Inline "math.compare($this, $n)">]
        static member CompareTo(n : int64) = X<int>

        [<Inline "math.compare($this, $n)">]
        static member CompareTo(n : obj) = X<int>

        [<Inline "math.compare($this, $n)">]
        static member CompareTo(n : uint64) = X<int>

        [<Inline "math.divide($n1, $n2)">]
        static member Divide(n1 : bigint, n2 : bigint) = X<bigint>

        [<Inline "math.equal($this, $n)">]
        static member Equals(n : bigint) = X<bool>
        
        [<Inline "math.equal($this, $n)">]
        static member Equals(n : int64) = X<bool>
        
        [<Inline "math.equal($this, $n)">]
        static member Equals(n : obj) = X<bool>
        
        [<Inline "math.equal($this, $n)">]
        static member Equals(n : uint64) = X<bool>

        [<Inline "math.gcd($n1, $n2)">]
        static member GreatestCommonDivisor(n1 : bigint, n2 : bigint) = X<bigint>

        [<Inline "math.log($n)">]
        static member Log(n : bigint) = X<float>

        [<Inline "math.log($n, $b)">]
        static member Log(n : bigint, b : float) = X<float>

        [<Inline "math.log10($n)">]
        static member Log10(n : bigint) = X<float>

        [<Inline "math.max($n1, $n2)">]
        static member Max(n1 : bigint, n2 : bigint) = X<bigint>

        [<Inline "math.min($n1, $n2)">]
        static member Min(n1 : bigint, n2 : bigint) = X<bigint>

        [<Inline "math.mod(math.pow($v, $e), $m)">]
        static member ModPow(v : bigint, e : bigint, m : bigint) = X<bigint>

        [<Inline "math.multiply($n1, $n2)">]
        static member Multiply(n1 : bigint, n2 : bigint) = X<bigint>

        [<Inline "math.bignumber($s)">]
        static member Parse(s : string) = X<bigint>

        [<Inline "math.pow($n1, $n2)">]
        static member Pow(n1 : bigint, n2 : int32) = X<bigint>

        [<Inline "math.mod($n1, $n2)">]
        static member Remainder(n1 : bigint, n2 : bigint) = X<bigint>

        [<Inline "math.subtract($n1, $n2)">]
        static member Subtract(n1 : bigint, n2 : bigint) = X<bigint>

        [<Inline "math.format($this)">]
        static member ToString() = X<string>
        
        [<Inline "math.add($n1, $n2)">]
        static member op_Addition(n1 : bigint, n2 : bigint) = X<bigint>

        [<Inline "math.bitAnd($n1, $n2)">]
        static member op_BitwiseAnd(n1 : bigint, n2 : bigint) = X<bigint>

        [<Inline "math.bitOr($n1, $n2)">]
        static member op_BitwiseOr(n1 : bigint, n2 : bigint) = X<bigint>

        [<Inline "math.divide($n1, $n2)">]
        static member op_Division(n1 : bigint, n2 : bigint) = X<bigint>

        [<Inline "math.equal($n1, $n2)">]
        static member op_Equality(n1 : bigint, n2 : bigint) = X<bool>

        [<Inline "math.equal($n1, $n2)">]
        static member op_Equality(n1 : bigint, n2 : int64) = X<bool>

        [<Inline "math.equal($n1, $n2)">]
        static member op_Equality(n1 : bigint, n2 : uint64) = X<bool>

        [<Inline "math.equal($n1, $n2)">]
        static member op_Equality(n1 : int64, n2 : bigint) = X<bool>

        [<Inline "math.equal($n1, $n2)">]
        static member op_Equality(n1 : uint64, n2 : bigint) = X<bool>

        [<Inline "math.bitxor($n1, $n2)">]
        static member op_ExclusiveOr(n1 : bigint, n2 : bigint) = X<bigint>

        [<Inline "!math.equal($n1, $n2)">]
        static member op_Inequality(n1 : bigint, n2 : bigint) = X<bool>

        [<Inline "!math.equal($n1, $n2)">]
        static member op_Inequality(n1 : bigint, n2 : int64) = X<bool>

        [<Inline "!math.equal($n1, $n2)">]
        static member op_Inequality(n1 : bigint, n2 : uint64) = X<bool>

        [<Inline "!math.equal($n1, $n2)">]
        static member op_Inequality(n1 : int64, n2 : bigint) = X<bool>

        [<Inline "!math.equal($n1, $n2)">]
        static member op_Inequality(n1 : uint64, n2 : bigint) = X<bool>

        [<Inline "math.mod($n1, $n2)">]
        static member op_Modulus(n1 : bigint, n2 : bigint) = X<bigint>

        [<Inline "math.multiply($n1, $n2)">]
        static member op_Multiply(n1 : bigint, n2 : bigint) = X<bigint>

        [<Inline "math.subtract($n1, $n2)">]
        static member op_Subtraction(n1 : bigint, n2 : bigint) = X<bigint>

        [<Inline "math.unaryMinus($n)">]
        static member op_UnaryNegation(n : bigint) = X<bigint>

        [<Inline "math.unaryPlus($n)">]
        static member op_UnaryPlus(n : bigint) = X<bigint>

    [<JavaScript>]
    let WSDecimalMath: MathJS.MathInstance =
        MathJS.Math.Create(Config(Number = "BigNumber", Precision = 29., Predictable = true))

    [<JavaScript>]
    let CreateDecimal(lo: int32, mid: int32, hi: int32, isNegative: bool, scale: byte) : decimal =
        let n(x:int) = (WSDecimalMath.Bignumber x) |> As<decimal>
        if lo = 0 && hi = 0 && mid = 0 then
            n 0
        else
            let uint_sup =
                System.Decimal.Add(System.Decimal.Multiply((n 429496729), (n 10)), (n 6))
            let reinterpret (x: int) = 
                if x >= 0 then
                    n(x)
                else
                    uint_sup + (n x)
            let quotient =
                WSDecimalMath.Pow((n 10 |> As<MathNumber>), WSDecimalMath.UnaryMinus((n <| int scale )|>As<MathNumber>)) |> As<decimal>
            let value =
                (((reinterpret hi) * uint_sup + reinterpret mid) * uint_sup + reinterpret lo)
            let sign = if isNegative then (n -1) else (n 1)
            sign * value * quotient

    [<JavaScript>]
    let CreateDecimalBits (bits : int32[]) =
        if bits.Length = 4 then
            let sign = (bits.[3] &&& 0x80000000) <> 0
            let scale = As<byte> ((bits.[3] >>> 16) &&& 0x7F)
            CreateDecimal(bits.[0], bits.[1], bits.[2], sign, scale) 
        else
           invalidArg "bits" "The length of the bits array is not 4"

    [<Proxy(typeof<System.Decimal>)>]
    [<Prototype(false)>]
    type DecimalProxy =

        [<Inline>]
        static member CtorProxy(lo: int32, mid: int32, hi: int32, isNegative: bool, scale: byte) : decimal =
            CreateDecimal(lo, mid, hi, isNegative, scale) 

        [<Inline>]
        static member CtorProxy(bits: int32[]): decimal =
            CreateDecimalBits bits

        [<Inline>]
        static member CtorProxy(v : decimal) : decimal = v

        [<Inline>]
        static member private mathn (v: decimal): MathNumber = As<MathNumber> v

        [<Inline>]
        static member private un<'T> (op: MathNumber -> MathNumber) (v: decimal): 'T = 
            DecimalProxy.mathn v
            |> op
            |> As<'T>

        [<Inline>]
        static member private bin (op: (MathNumber * MathNumber) -> MathNumber) (v1: decimal) (v2: decimal): 'T = 
            op (DecimalProxy.mathn v1, DecimalProxy.mathn v2)
            |> As<'T>

        [<Inline>]
        static member private mul (op: (MathNumber * MathNumber * MathNumber []) -> MathNumber) (v1: decimal) (v2: decimal): 'T = 
            op (DecimalProxy.mathn v1, DecimalProxy.mathn v2, [||])
            |> As<'T>

        [<Inline>]
        static member CtorProxy(v : double) : decimal = WSDecimalMath.Bignumber(MathNumber(v)) |> As<decimal>

        [<Inline>]
        static member CtorProxy(v : int32) : decimal = WSDecimalMath.Bignumber(MathNumber(v)) |> As<decimal>

        [<Inline>]
        static member CtorProxy(v : int64) : decimal = WSDecimalMath.Bignumber(MathNumber(v)) |> As<decimal>

        [<Inline>]
        static member CtorProxy(v : single) : decimal = WSDecimalMath.Bignumber(MathNumber(v)) |> As<decimal>

        [<Inline>]
        static member CtorProxy(v : uint32) : decimal = WSDecimalMath.Bignumber(MathNumber(v)) |> As<decimal>

        [<Inline>]
        static member CtorProxy(v : uint64) : decimal = WSDecimalMath.Bignumber(MathNumber(v)) |> As<decimal>

        [<Inline>]
        static member Abs(n : decimal) : decimal = DecimalProxy.un WSDecimalMath.Abs n

        [<Inline>]
        static member Add(n1 : decimal, n2 : decimal) : decimal = DecimalProxy.mul WSDecimalMath.Add n1 n2

        [<Inline>]
        static member Compare(n1 : decimal, n2 : decimal) : int = DecimalProxy.bin WSDecimalMath.Compare n1 n2

        [<Inline>]
        member this.CompareTo(n : decimal) : int = DecimalProxy.bin WSDecimalMath.Compare (this |> As<decimal>) n

        [<Inline>]
        member this.CompareTo(n : obj) :int =
            let math = WSDecimalMath
            JS.Inline ("$0.compare($this,$n)", math, this, n)

        [<Inline>]
        static member Divide(n1 : decimal, n2 : decimal): decimal = DecimalProxy.bin WSDecimalMath.Divide n1 n2

        [<Inline>]
        member this.Equals(n : decimal): bool = DecimalProxy.bin WSDecimalMath.Equal (this |> As<decimal>) n

        [<Inline>]
        static member Equals(a: decimal, b : decimal): bool = DecimalProxy.bin WSDecimalMath.Equal a b

        [<Inline>]
        static member GreatestCommonDivisor(n1 : decimal, n2 : decimal): decimal = DecimalProxy.bin WSDecimalMath.Gcd n1 n2

        [<Inline>]
        static member Log(n : decimal): decimal = DecimalProxy.un WSDecimalMath.Log n

        [<Inline>]
        static member Log(n : decimal, b : decimal): decimal = DecimalProxy.bin WSDecimalMath.Log n b

        [<Inline>]
        static member Log10(n : decimal): decimal = DecimalProxy.un WSDecimalMath.Log10 n

        [<Inline>]
        static member Max(n1 : decimal, n2 : decimal): decimal =
            if n1 >= n2 then
                n1
            else
                n2

        [<Inline>]
        static member Min(n1 : decimal, n2 : decimal): decimal =
            if n1 <= n2 then
                n1
            else
                n2

        [<Inline>]
        static member ModPow(v : decimal, e : decimal, m : decimal): decimal =
            JS.Inline ("$0.mod($0.pow($1, $2), $3)", WSDecimalMath, v, e, m)

        [<Inline>]
        static member Multiply(n1 : decimal, n2 : decimal): decimal = DecimalProxy.mul WSDecimalMath.Multiply n1 n2

        [<Inline>]
        static member Parse(s : string) = WSDecimalMath.Bignumber(MathNumber(s)) |> As<decimal>

        [<Inline>]
        static member Pow(n1 : decimal, n2 : int32): decimal = DecimalProxy.bin WSDecimalMath.Pow n1 (MathNumber(n2) |> As<decimal>)

        [<Inline>]
        static member Remainder(n1 : decimal, n2 : decimal): decimal = DecimalProxy.bin WSDecimalMath.Mod n1 n2

        [<Inline>]
        static member Subtract(n1 : decimal, n2 : decimal): decimal = DecimalProxy.bin WSDecimalMath.Subtract n1 n2
        (*
        [<Inline>]
        override this.ToString() =
            let math = WSDecimalMath
            JS.Inline ("$0.format($1)", math, this)
        *)
        [<Inline>]
        static member op_Addition(n1 : decimal, n2 : decimal): decimal = DecimalProxy.Add (n1, n2)

        [<Inline>]
        static member op_BitwiseAnd(n1 : decimal, n2 : decimal): decimal = DecimalProxy.bin WSDecimalMath.BitAnd n1 n2

        [<Inline>]
        static member op_BitwiseOr(n1 : decimal, n2 : decimal): decimal = DecimalProxy.bin WSDecimalMath.BitOr n1 n2

        [<Inline>]
        static member op_Division(n1 : decimal, n2 : decimal): decimal = DecimalProxy.bin WSDecimalMath.Divide n1 n2

        [<Inline>]
        static member op_Equality(n1 : decimal, n2 : decimal): bool = DecimalProxy.Equals (n1,n2)

        [<Inline>]
        static member op_ExclusiveOr(n1 : decimal, n2 : decimal): decimal = DecimalProxy.bin WSDecimalMath.BitXor n1 n2

        [<Inline>]
        static member op_Inequality(n1 : decimal, n2 : decimal): bool = not <| DecimalProxy.Equals (n1,n2)

        [<Inline>]
        static member op_Modulus(n1 : decimal, n2 : decimal): decimal = DecimalProxy.bin WSDecimalMath.Mod n1 n2

        [<Inline>]
        static member op_Multiply(n1 : decimal, n2 : decimal): decimal = DecimalProxy.Multiply (n1, n2)

        [<Inline>]
        static member op_Subtraction(n1 : decimal, n2 : decimal) = DecimalProxy.Subtract (n1,n2)

        [<Inline>]
        static member op_UnaryNegation(n : decimal): decimal = DecimalProxy.un WSDecimalMath.UnaryMinus n

        [<Inline>]
        static member op_UnaryPlus(n : decimal) : decimal = DecimalProxy.un WSDecimalMath.UnaryPlus n

    [<Proxy "Microsoft.FSharp.Core.LanguagePrimitives+IntrinsicFunctions, \
         FSharp.Core, Culture=neutral, \
         PublicKeyToken=b03f5f7f11d50a3a">]
    module private IntrinsicFunctionProxy =
        [<Inline>]
        [<Name "Microsoft.FSharp.Core.LanguagePrimitives.IntrinsicFunctions.MakeDecimal">]
        let MakeDecimal lo med hi isNegative scale = System.Decimal(lo,med,hi,isNegative,scale)
