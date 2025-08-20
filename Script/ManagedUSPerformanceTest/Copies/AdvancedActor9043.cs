using UnrealSharp;
using UnrealSharp.Attributes;
using UnrealSharp.Engine;

namespace ManagedUSPerformanceTest
{
    // Multicast delegates.
    [UMultiDelegate]
    public delegate void MyShowcaseMulticastDelegate90431(int a);
    // Multicast delegates.
    [UMultiDelegate]
    public delegate void MyShowcaseMulticastDelegate90432(int a);
    // Multicast delegates.
    [UMultiDelegate]
    public delegate void MyShowcaseMulticastDelegate90433(int a);
    // Multicast delegates.
    [UMultiDelegate]
    public delegate void MyShowcaseMulticastDelegate90434(int a);
    [UClass]
    public class AAdvancedActor9043 : AActor
    {

        [UProperty(PropertyFlags.EditAnywhere | PropertyFlags.BlueprintReadWrite)]
        public int MyProperty { get; set; }
        [UProperty(PropertyFlags.EditAnywhere | PropertyFlags.BlueprintReadWrite)]
        public bool MyProperty1 { get; set; }
        [UProperty(PropertyFlags.EditAnywhere | PropertyFlags.BlueprintReadWrite)]
        public int MyProperty2 { get; set; }

        [UProperty(PropertyFlags.EditAnywhere | PropertyFlags.BlueprintReadWrite)]
        public int MyProperty5 { get; set; }

        [UProperty(DefaultComponent = true, RootComponent = true)]
        public USceneComponent MyRootComponent { get; set; }

        [UProperty(DefaultComponent = true, AttachmentComponent = nameof(MyRootComponent))]
        public USceneComponent MyRootComponent2 { get; set; }
        [UProperty(DefaultComponent = true, AttachmentComponent = nameof(MyRootComponent))]
        public USceneComponent MyRootComponent3 { get; set; }
        [UProperty(DefaultComponent = true, AttachmentComponent = nameof(MyRootComponent))]
        public USceneComponent MyRootComponent4 { get; set; }
        [UProperty(DefaultComponent = true, AttachmentComponent = nameof(MyRootComponent))]
        public USceneComponent MyRootComponent5 { get; set; }


        [UProperty(PropertyFlags.BlueprintAssignable)]
        public TMulticastDelegate<MyShowcaseMulticastDelegate90431> MyMulticastDelegate { get; set; }

        [UProperty(PropertyFlags.BlueprintAssignable)]
        public TMulticastDelegate<MyShowcaseMulticastDelegate90432> MyMulticastDelegate2 { get; set; }

        [UProperty(PropertyFlags.BlueprintAssignable)]
        public TMulticastDelegate<MyShowcaseMulticastDelegate90433> MyMulticastDelegate3 { get; set; }

        [UProperty(PropertyFlags.BlueprintAssignable)]
        public TMulticastDelegate<MyShowcaseMulticastDelegate90434> MyMulticastDelegate4 { get; set; }


        protected override void BeginPlay()
        {
            base.BeginPlay();
        }

        public override void Tick(float deltaSeconds)
        {
            base.Tick(deltaSeconds);
        }

        protected override void EndPlay(EEndPlayReason endPlayReason)
        {
            base.EndPlay(endPlayReason);
        }

        [UFunction(FunctionFlags.BlueprintEvent | FunctionFlags.BlueprintCallable)]
        public void MyFunction()
        {
            // This function is intentionally left empty.
        }

        [UFunction(FunctionFlags.BlueprintEvent | FunctionFlags.BlueprintCallable)]
        public bool MyFunctionWithReturnValue()
        {
            // This function is intentionally left empty.
            return true;
        }

        [UFunction(FunctionFlags.BlueprintEvent | FunctionFlags.BlueprintCallable)]
        public void MyFunctionWithParameters(int a, float b, string c)
        {
            // This function is intentionally left empty.
        }

        [UFunction(FunctionFlags.BlueprintEvent | FunctionFlags.BlueprintCallable)]
        public void MyFunctionWithParametersAndReturnValue(int a, float b, string c, out int d)
        {
            // This function is intentionally left empty.
            d = 0; // Example output parameter
        }

        [UFunction(FunctionFlags.BlueprintEvent | FunctionFlags.BlueprintCallable)]
        public void MyFunctionWithParametersAndReturnValue2(int a, float b, string c, out int d, out float e)
        {
            // This function is intentionally left empty.
            d = 0; // Example output parameter
            e = 0.0f; // Example output parameter
        }
    }
}
