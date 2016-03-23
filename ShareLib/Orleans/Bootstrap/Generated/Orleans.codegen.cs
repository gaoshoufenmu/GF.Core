#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("Orleans, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null")]
namespace Orleans
{
    using global::Orleans.Async;
    using global::Orleans;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.GrainState<>))]
    internal class OrleansCodeGenOrleans_GrainStateSerializer<T>
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.GrainState<T>).@GetField("State", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.GrainState<T>, T> getField0 = (global::System.Func<global::Orleans.GrainState<T>, T>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.GrainState<T>, T> setField0 = (global::System.Action<global::Orleans.GrainState<T>, T>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.GrainState<T> input = ((global::Orleans.GrainState<T>)original);
            global::Orleans.GrainState<T> result = new global::Orleans.GrainState<T>();
            result.@ETag = input.@ETag;
            setField0(result, (T)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.GrainState<T> input = (global::Orleans.GrainState<T>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ETag, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.GrainState<T> result = new global::Orleans.GrainState<T>();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@ETag = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            setField0(result, (T)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T), stream));
            return (global::Orleans.GrainState<T>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_GrainStateSerializer_T_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.GrainState<>), typeof (OrleansCodeGenOrleans_GrainStateSerializer<>));
        }

        static OrleansCodeGenOrleans_GrainStateSerializer_T_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.TableVersion)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_TableVersionSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.TableVersion).@GetField("<Version>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.TableVersion, global::System.Int32> setField0 = (global::System.Action<global::Orleans.TableVersion, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.TableVersion).@GetField("<VersionEtag>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.TableVersion, global::System.String> setField1 = (global::System.Action<global::Orleans.TableVersion, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            return original;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.TableVersion input = (global::Orleans.TableVersion)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Version, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@VersionEtag, stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.TableVersion result = (global::Orleans.TableVersion)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.TableVersion));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField1(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            return (global::Orleans.TableVersion)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.TableVersion), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_TableVersionSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.MembershipTableData)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_MembershipTableDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.MembershipTableData).@GetField("<Members>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.MembershipTableData, global::System.Collections.Generic.IReadOnlyList<global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>> setField0 = (global::System.Action<global::Orleans.MembershipTableData, global::System.Collections.Generic.IReadOnlyList<global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.MembershipTableData).@GetField("<Version>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.MembershipTableData, global::Orleans.TableVersion> setField1 = (global::System.Action<global::Orleans.MembershipTableData, global::Orleans.TableVersion>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.MembershipTableData input = ((global::Orleans.MembershipTableData)original);
            global::Orleans.MembershipTableData result = (global::Orleans.MembershipTableData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.MembershipTableData));
            setField0(result, (global::System.Collections.Generic.IReadOnlyList<global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Members));
            setField1(result, input.@Version);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.MembershipTableData input = (global::Orleans.MembershipTableData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Members, stream, typeof (global::System.Collections.Generic.IReadOnlyList<global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Version, stream, typeof (global::Orleans.TableVersion));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.MembershipTableData result = (global::Orleans.MembershipTableData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.MembershipTableData));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Collections.Generic.IReadOnlyList<global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IReadOnlyList<global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>), stream));
            setField1(result, (global::Orleans.TableVersion)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.TableVersion), stream));
            return (global::Orleans.MembershipTableData)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.MembershipTableData), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_MembershipTableDataSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.MembershipEntry)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_MembershipEntrySerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.MembershipEntry input = ((global::Orleans.MembershipEntry)original);
            global::Orleans.MembershipEntry result = new global::Orleans.MembershipEntry();
            result.@FaultZone = input.@FaultZone;
            result.@HostName = input.@HostName;
            result.@IAmAliveTime = input.@IAmAliveTime;
            result.@InstanceName = input.@InstanceName;
            result.@ProxyPort = input.@ProxyPort;
            result.@RoleName = input.@RoleName;
            result.@SiloAddress = (global::Orleans.Runtime.SiloAddress)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@SiloAddress);
            result.@StartTime = input.@StartTime;
            result.@Status = input.@Status;
            result.@SuspectTimes = (global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.SiloAddress, global::System.DateTime>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@SuspectTimes);
            result.@UpdateZone = input.@UpdateZone;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.MembershipEntry input = (global::Orleans.MembershipEntry)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@FaultZone, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@HostName, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@IAmAliveTime, stream, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@InstanceName, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ProxyPort, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@RoleName, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SiloAddress, stream, typeof (global::Orleans.Runtime.SiloAddress));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StartTime, stream, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Status, stream, typeof (global::Orleans.Runtime.SiloStatus));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SuspectTimes, stream, typeof (global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.SiloAddress, global::System.DateTime>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@UpdateZone, stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.MembershipEntry result = new global::Orleans.MembershipEntry();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@FaultZone = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@HostName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@IAmAliveTime = (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), stream);
            result.@InstanceName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@ProxyPort = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@RoleName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@SiloAddress = (global::Orleans.Runtime.SiloAddress)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.SiloAddress), stream);
            result.@StartTime = (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), stream);
            result.@Status = (global::Orleans.Runtime.SiloStatus)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.SiloStatus), stream);
            result.@SuspectTimes = (global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.SiloAddress, global::System.DateTime>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.SiloAddress, global::System.DateTime>>), stream);
            result.@UpdateZone = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            return (global::Orleans.MembershipEntry)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.MembershipEntry), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_MembershipEntrySerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.ReminderEntry)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_ReminderEntrySerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.ReminderEntry input = ((global::Orleans.ReminderEntry)original);
            global::Orleans.ReminderEntry result = new global::Orleans.ReminderEntry();
            result.@ETag = input.@ETag;
            result.@GrainRef = (global::Orleans.Runtime.GrainReference)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@GrainRef);
            result.@Period = input.@Period;
            result.@ReminderName = input.@ReminderName;
            result.@StartAt = input.@StartAt;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.ReminderEntry input = (global::Orleans.ReminderEntry)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ETag, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GrainRef, stream, typeof (global::Orleans.Runtime.GrainReference));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Period, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ReminderName, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StartAt, stream, typeof (global::System.DateTime));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.ReminderEntry result = new global::Orleans.ReminderEntry();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@ETag = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@GrainRef = (global::Orleans.Runtime.GrainReference)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.GrainReference), stream);
            result.@Period = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream);
            result.@ReminderName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@StartAt = (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), stream);
            return (global::Orleans.ReminderEntry)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.ReminderEntry), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_ReminderEntrySerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.ReminderData)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_ReminderDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.ReminderData).@GetField("<ETag>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.ReminderData, global::System.String> setField2 = (global::System.Action<global::Orleans.ReminderData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.ReminderData).@GetField("<GrainRef>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.ReminderData, global::Orleans.Runtime.GrainReference> setField0 = (global::System.Action<global::Orleans.ReminderData, global::Orleans.Runtime.GrainReference>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.ReminderData).@GetField("<ReminderName>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.ReminderData, global::System.String> setField1 = (global::System.Action<global::Orleans.ReminderData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.ReminderData input = ((global::Orleans.ReminderData)original);
            global::Orleans.ReminderData result = (global::Orleans.ReminderData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.ReminderData));
            setField2(result, input.@ETag);
            setField0(result, (global::Orleans.Runtime.GrainReference)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@GrainRef));
            setField1(result, input.@ReminderName);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.ReminderData input = (global::Orleans.ReminderData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ETag, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GrainRef, stream, typeof (global::Orleans.Runtime.GrainReference));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ReminderName, stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.ReminderData result = (global::Orleans.ReminderData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.ReminderData));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField2(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField0(result, (global::Orleans.Runtime.GrainReference)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.GrainReference), stream));
            setField1(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            return (global::Orleans.ReminderData)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.ReminderData), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_ReminderDataSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.ObserverSubscriptionManager<>))]
    internal class OrleansCodeGenOrleans_ObserverSubscriptionManagerSerializer<T>
        where T : global::Orleans.IGrainObserver
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.ObserverSubscriptionManager<T>).@GetField("observers", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.ObserverSubscriptionManager<T>, global::System.Collections.Generic.HashSet<T>> getField0 = (global::System.Func<global::Orleans.ObserverSubscriptionManager<T>, global::System.Collections.Generic.HashSet<T>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.ObserverSubscriptionManager<T>, global::System.Collections.Generic.HashSet<T>> setField0 = (global::System.Action<global::Orleans.ObserverSubscriptionManager<T>, global::System.Collections.Generic.HashSet<T>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.ObserverSubscriptionManager<T> input = ((global::Orleans.ObserverSubscriptionManager<T>)original);
            global::Orleans.ObserverSubscriptionManager<T> result = new global::Orleans.ObserverSubscriptionManager<T>();
            setField0(result, (global::System.Collections.Generic.HashSet<T>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.ObserverSubscriptionManager<T> input = (global::Orleans.ObserverSubscriptionManager<T>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Collections.Generic.HashSet<T>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.ObserverSubscriptionManager<T> result = new global::Orleans.ObserverSubscriptionManager<T>();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Collections.Generic.HashSet<T>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.HashSet<T>), stream));
            return (global::Orleans.ObserverSubscriptionManager<T>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_ObserverSubscriptionManagerSerializer_T_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.ObserverSubscriptionManager<>), typeof (OrleansCodeGenOrleans_ObserverSubscriptionManagerSerializer<>));
        }

        static OrleansCodeGenOrleans_ObserverSubscriptionManagerSerializer_T_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.StreamHandshakeToken)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Streams_StreamHandshakeTokenSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.StreamHandshakeToken).@GetField("<Token>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Streams.StreamHandshakeToken, global::Orleans.Streams.StreamSequenceToken> setField0 = (global::System.Action<global::Orleans.Streams.StreamHandshakeToken, global::Orleans.Streams.StreamSequenceToken>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Streams.StreamHandshakeToken input = ((global::Orleans.Streams.StreamHandshakeToken)original);
            global::Orleans.Streams.StreamHandshakeToken result = new global::Orleans.Streams.StreamHandshakeToken();
            setField0(result, (global::Orleans.Streams.StreamSequenceToken)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Token));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Streams.StreamHandshakeToken input = (global::Orleans.Streams.StreamHandshakeToken)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Token, stream, typeof (global::Orleans.Streams.StreamSequenceToken));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Streams.StreamHandshakeToken result = new global::Orleans.Streams.StreamHandshakeToken();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::Orleans.Streams.StreamSequenceToken)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamSequenceToken), stream));
            return (global::Orleans.Streams.StreamHandshakeToken)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Streams.StreamHandshakeToken), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Streams_StreamHandshakeTokenSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.StartToken)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Streams_StartTokenSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.StreamHandshakeToken).@GetField("<Token>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Streams.StreamHandshakeToken, global::Orleans.Streams.StreamSequenceToken> setField0 = (global::System.Action<global::Orleans.Streams.StreamHandshakeToken, global::Orleans.Streams.StreamSequenceToken>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Streams.StartToken input = ((global::Orleans.Streams.StartToken)original);
            global::Orleans.Streams.StartToken result = new global::Orleans.Streams.StartToken();
            setField0(result, (global::Orleans.Streams.StreamSequenceToken)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Token));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Streams.StartToken input = (global::Orleans.Streams.StartToken)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Token, stream, typeof (global::Orleans.Streams.StreamSequenceToken));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Streams.StartToken result = new global::Orleans.Streams.StartToken();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::Orleans.Streams.StreamSequenceToken)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamSequenceToken), stream));
            return (global::Orleans.Streams.StartToken)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Streams.StartToken), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Streams_StartTokenSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.DeliveryToken)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Streams_DeliveryTokenSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.StreamHandshakeToken).@GetField("<Token>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Streams.StreamHandshakeToken, global::Orleans.Streams.StreamSequenceToken> setField0 = (global::System.Action<global::Orleans.Streams.StreamHandshakeToken, global::Orleans.Streams.StreamSequenceToken>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Streams.DeliveryToken input = ((global::Orleans.Streams.DeliveryToken)original);
            global::Orleans.Streams.DeliveryToken result = new global::Orleans.Streams.DeliveryToken();
            setField0(result, (global::Orleans.Streams.StreamSequenceToken)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Token));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Streams.DeliveryToken input = (global::Orleans.Streams.DeliveryToken)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Token, stream, typeof (global::Orleans.Streams.StreamSequenceToken));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Streams.DeliveryToken result = new global::Orleans.Streams.DeliveryToken();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::Orleans.Streams.StreamSequenceToken)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamSequenceToken), stream));
            return (global::Orleans.Streams.DeliveryToken)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Streams.DeliveryToken), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Streams_DeliveryTokenSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.StreamSubscriptionHandleImpl<>))]
    internal class OrleansCodeGenOrleans_Streams_StreamSubscriptionHandleImplSerializer<T>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Streams.StreamSubscriptionHandleImpl<T>).@GetField("filterWrapper", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::Orleans.Streams.IStreamFilterPredicateWrapper> getField1 = (global::System.Func<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::Orleans.Streams.IStreamFilterPredicateWrapper>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::Orleans.Streams.IStreamFilterPredicateWrapper> setField1 = (global::System.Action<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::Orleans.Streams.IStreamFilterPredicateWrapper>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.StreamSubscriptionHandleImpl<T>).@GetField("streamImpl", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::Orleans.Streams.StreamImpl<T>> getField0 = (global::System.Func<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::Orleans.Streams.StreamImpl<T>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::Orleans.Streams.StreamImpl<T>> setField0 = (global::System.Action<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::Orleans.Streams.StreamImpl<T>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Streams.StreamSubscriptionHandleImpl<T>).@GetField("subscriptionId", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::Orleans.Runtime.GuidId> getField2 = (global::System.Func<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::Orleans.Runtime.GuidId>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::Orleans.Runtime.GuidId> setField2 = (global::System.Action<global::Orleans.Streams.StreamSubscriptionHandleImpl<T>, global::Orleans.Runtime.GuidId>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Streams.StreamSubscriptionHandleImpl<T> input = ((global::Orleans.Streams.StreamSubscriptionHandleImpl<T>)original);
            global::Orleans.Streams.StreamSubscriptionHandleImpl<T> result = (global::Orleans.Streams.StreamSubscriptionHandleImpl<T>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.StreamSubscriptionHandleImpl<T>));
            setField1(result, (global::Orleans.Streams.IStreamFilterPredicateWrapper)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input)));
            setField0(result, getField0(input));
            setField2(result, getField2(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Streams.StreamSubscriptionHandleImpl<T> input = (global::Orleans.Streams.StreamSubscriptionHandleImpl<T>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::Orleans.Streams.IStreamFilterPredicateWrapper));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::Orleans.Streams.StreamImpl<T>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (global::Orleans.Runtime.GuidId));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Streams.StreamSubscriptionHandleImpl<T> result = (global::Orleans.Streams.StreamSubscriptionHandleImpl<T>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.StreamSubscriptionHandleImpl<T>));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::Orleans.Streams.IStreamFilterPredicateWrapper)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.IStreamFilterPredicateWrapper), stream));
            setField0(result, (global::Orleans.Streams.StreamImpl<T>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamImpl<T>), stream));
            setField2(result, (global::Orleans.Runtime.GuidId)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.GuidId), stream));
            return (global::Orleans.Streams.StreamSubscriptionHandleImpl<T>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Streams_StreamSubscriptionHandleImplSerializer_T_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Streams.StreamSubscriptionHandleImpl<>), typeof (OrleansCodeGenOrleans_Streams_StreamSubscriptionHandleImplSerializer<>));
        }

        static OrleansCodeGenOrleans_Streams_StreamSubscriptionHandleImplSerializer_T_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.FilterPredicateWrapperData)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Streams_FilterPredicateWrapperDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.FilterPredicateWrapperData).@GetField("<FilterData>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Streams.FilterPredicateWrapperData, global::System.Object> setField0 = (global::System.Action<global::Orleans.Streams.FilterPredicateWrapperData, global::System.Object>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Streams.FilterPredicateWrapperData).@GetField("className", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.FilterPredicateWrapperData, global::System.String> getField2 = (global::System.Func<global::Orleans.Streams.FilterPredicateWrapperData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Streams.FilterPredicateWrapperData, global::System.String> setField2 = (global::System.Action<global::Orleans.Streams.FilterPredicateWrapperData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Streams.FilterPredicateWrapperData).@GetField("methodName", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.FilterPredicateWrapperData, global::System.String> getField1 = (global::System.Func<global::Orleans.Streams.FilterPredicateWrapperData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Streams.FilterPredicateWrapperData, global::System.String> setField1 = (global::System.Action<global::Orleans.Streams.FilterPredicateWrapperData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Streams.FilterPredicateWrapperData input = ((global::Orleans.Streams.FilterPredicateWrapperData)original);
            global::Orleans.Streams.FilterPredicateWrapperData result = (global::Orleans.Streams.FilterPredicateWrapperData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.FilterPredicateWrapperData));
            setField0(result, (global::System.Object)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@FilterData));
            setField2(result, getField2(input));
            setField1(result, getField1(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Streams.FilterPredicateWrapperData input = (global::Orleans.Streams.FilterPredicateWrapperData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@FilterData, stream, typeof (global::System.Object));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Streams.FilterPredicateWrapperData result = (global::Orleans.Streams.FilterPredicateWrapperData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.FilterPredicateWrapperData));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Object)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Object), stream));
            setField2(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField1(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            return (global::Orleans.Streams.FilterPredicateWrapperData)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Streams.FilterPredicateWrapperData), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Streams_FilterPredicateWrapperDataSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.PersistentStreamProviderConfig)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Streams_PersistentStreamProviderConfigSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Streams.PersistentStreamProviderConfig).@GetField("<BalancerType>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Streams.PersistentStreamProviderConfig, global::Orleans.Streams.StreamQueueBalancerType> setField4 = (global::System.Action<global::Orleans.Streams.PersistentStreamProviderConfig, global::Orleans.Streams.StreamQueueBalancerType>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.PersistentStreamProviderConfig).@GetField("<GetQueueMsgsTimerPeriod>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Streams.PersistentStreamProviderConfig, global::System.TimeSpan> setField0 = (global::System.Action<global::Orleans.Streams.PersistentStreamProviderConfig, global::System.TimeSpan>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Streams.PersistentStreamProviderConfig).@GetField("<InitQueueTimeout>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Streams.PersistentStreamProviderConfig, global::System.TimeSpan> setField1 = (global::System.Action<global::Orleans.Streams.PersistentStreamProviderConfig, global::System.TimeSpan>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Streams.PersistentStreamProviderConfig).@GetField("<MaxEventDeliveryTime>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Streams.PersistentStreamProviderConfig, global::System.TimeSpan> setField2 = (global::System.Action<global::Orleans.Streams.PersistentStreamProviderConfig, global::System.TimeSpan>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Orleans.Streams.PersistentStreamProviderConfig).@GetField("<PubSubType>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Streams.PersistentStreamProviderConfig, global::Orleans.Streams.StreamPubSubType> setField5 = (global::System.Action<global::Orleans.Streams.PersistentStreamProviderConfig, global::Orleans.Streams.StreamPubSubType>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Orleans.Streams.PersistentStreamProviderConfig).@GetField("<SiloMaturityPeriod>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Streams.PersistentStreamProviderConfig, global::System.TimeSpan> setField6 = (global::System.Action<global::Orleans.Streams.PersistentStreamProviderConfig, global::System.TimeSpan>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field6);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Streams.PersistentStreamProviderConfig).@GetField("<StreamInactivityPeriod>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Streams.PersistentStreamProviderConfig, global::System.TimeSpan> setField3 = (global::System.Action<global::Orleans.Streams.PersistentStreamProviderConfig, global::System.TimeSpan>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Streams.PersistentStreamProviderConfig input = ((global::Orleans.Streams.PersistentStreamProviderConfig)original);
            global::Orleans.Streams.PersistentStreamProviderConfig result = (global::Orleans.Streams.PersistentStreamProviderConfig)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.PersistentStreamProviderConfig));
            setField4(result, input.@BalancerType);
            setField0(result, input.@GetQueueMsgsTimerPeriod);
            setField1(result, input.@InitQueueTimeout);
            setField2(result, input.@MaxEventDeliveryTime);
            setField5(result, input.@PubSubType);
            setField6(result, input.@SiloMaturityPeriod);
            setField3(result, input.@StreamInactivityPeriod);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Streams.PersistentStreamProviderConfig input = (global::Orleans.Streams.PersistentStreamProviderConfig)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@BalancerType, stream, typeof (global::Orleans.Streams.StreamQueueBalancerType));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GetQueueMsgsTimerPeriod, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@InitQueueTimeout, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxEventDeliveryTime, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@PubSubType, stream, typeof (global::Orleans.Streams.StreamPubSubType));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SiloMaturityPeriod, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StreamInactivityPeriod, stream, typeof (global::System.TimeSpan));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Streams.PersistentStreamProviderConfig result = (global::Orleans.Streams.PersistentStreamProviderConfig)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.PersistentStreamProviderConfig));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField4(result, (global::Orleans.Streams.StreamQueueBalancerType)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamQueueBalancerType), stream));
            setField0(result, (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream));
            setField1(result, (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream));
            setField2(result, (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream));
            setField5(result, (global::Orleans.Streams.StreamPubSubType)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamPubSubType), stream));
            setField6(result, (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream));
            setField3(result, (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream));
            return (global::Orleans.Streams.PersistentStreamProviderConfig)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Streams.PersistentStreamProviderConfig), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Streams_PersistentStreamProviderConfigSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.ImplicitStreamSubscriberTable)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Streams_ImplicitStreamSubscriberTableSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.ImplicitStreamSubscriberTable).@GetField("table", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.ImplicitStreamSubscriberTable, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.HashSet<global::System.Int32>>> getField0 = (global::System.Func<global::Orleans.Streams.ImplicitStreamSubscriberTable, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.HashSet<global::System.Int32>>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Streams.ImplicitStreamSubscriberTable, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.HashSet<global::System.Int32>>> setField0 = (global::System.Action<global::Orleans.Streams.ImplicitStreamSubscriberTable, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.HashSet<global::System.Int32>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Streams.ImplicitStreamSubscriberTable input = ((global::Orleans.Streams.ImplicitStreamSubscriberTable)original);
            global::Orleans.Streams.ImplicitStreamSubscriberTable result = (global::Orleans.Streams.ImplicitStreamSubscriberTable)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.ImplicitStreamSubscriberTable));
            setField0(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.HashSet<global::System.Int32>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Streams.ImplicitStreamSubscriberTable input = (global::Orleans.Streams.ImplicitStreamSubscriberTable)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.HashSet<global::System.Int32>>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Streams.ImplicitStreamSubscriberTable result = (global::Orleans.Streams.ImplicitStreamSubscriberTable)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.ImplicitStreamSubscriberTable));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.HashSet<global::System.Int32>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.HashSet<global::System.Int32>>), stream));
            return (global::Orleans.Streams.ImplicitStreamSubscriberTable)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Streams.ImplicitStreamSubscriberTable), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Streams_ImplicitStreamSubscriberTableSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.PubSubPublisherState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Streams_PubSubPublisherStateSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.PubSubPublisherState).@GetField("Stream", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.PubSubPublisherState, global::Orleans.Streams.StreamId> getField0 = (global::System.Func<global::Orleans.Streams.PubSubPublisherState, global::Orleans.Streams.StreamId>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Streams.PubSubPublisherState, global::Orleans.Streams.StreamId> setField0 = (global::System.Action<global::Orleans.Streams.PubSubPublisherState, global::Orleans.Streams.StreamId>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Streams.PubSubPublisherState).@GetField("producerReference", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.PubSubPublisherState, global::Orleans.Runtime.GrainReference> getField1 = (global::System.Func<global::Orleans.Streams.PubSubPublisherState, global::Orleans.Runtime.GrainReference>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Streams.PubSubPublisherState, global::Orleans.Runtime.GrainReference> setField1 = (global::System.Action<global::Orleans.Streams.PubSubPublisherState, global::Orleans.Runtime.GrainReference>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Streams.PubSubPublisherState input = ((global::Orleans.Streams.PubSubPublisherState)original);
            global::Orleans.Streams.PubSubPublisherState result = (global::Orleans.Streams.PubSubPublisherState)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.PubSubPublisherState));
            setField0(result, getField0(input));
            setField1(result, (global::Orleans.Runtime.GrainReference)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Streams.PubSubPublisherState input = (global::Orleans.Streams.PubSubPublisherState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::Orleans.Streams.StreamId));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::Orleans.Runtime.GrainReference));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Streams.PubSubPublisherState result = (global::Orleans.Streams.PubSubPublisherState)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.PubSubPublisherState));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::Orleans.Streams.StreamId)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamId), stream));
            setField1(result, (global::Orleans.Runtime.GrainReference)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.GrainReference), stream));
            return (global::Orleans.Streams.PubSubPublisherState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Streams.PubSubPublisherState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Streams_PubSubPublisherStateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.PubSubSubscriptionState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Streams_PubSubSubscriptionStateSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Streams.PubSubSubscriptionState).@GetField("Stream", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Streams.StreamId> getField1 = (global::System.Func<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Streams.StreamId>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Streams.StreamId> setField1 = (global::System.Action<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Streams.StreamId>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.PubSubSubscriptionState).@GetField("SubscriptionId", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Runtime.GuidId> getField0 = (global::System.Func<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Runtime.GuidId>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Runtime.GuidId> setField0 = (global::System.Action<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Runtime.GuidId>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Streams.PubSubSubscriptionState).@GetField("consumerReference", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Runtime.GrainReference> getField2 = (global::System.Func<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Runtime.GrainReference>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Runtime.GrainReference> setField2 = (global::System.Action<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Runtime.GrainReference>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Streams.PubSubSubscriptionState).@GetField("filterWrapper", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.PubSubSubscriptionState, global::System.Object> getField3 = (global::System.Func<global::Orleans.Streams.PubSubSubscriptionState, global::System.Object>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Orleans.Streams.PubSubSubscriptionState, global::System.Object> setField3 = (global::System.Action<global::Orleans.Streams.PubSubSubscriptionState, global::System.Object>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Streams.PubSubSubscriptionState).@GetField("state", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Streams.PubSubSubscriptionState.SubscriptionStates> getField4 = (global::System.Func<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Streams.PubSubSubscriptionState.SubscriptionStates>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Streams.PubSubSubscriptionState.SubscriptionStates> setField4 = (global::System.Action<global::Orleans.Streams.PubSubSubscriptionState, global::Orleans.Streams.PubSubSubscriptionState.SubscriptionStates>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Streams.PubSubSubscriptionState input = ((global::Orleans.Streams.PubSubSubscriptionState)original);
            global::Orleans.Streams.PubSubSubscriptionState result = (global::Orleans.Streams.PubSubSubscriptionState)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.PubSubSubscriptionState));
            setField1(result, getField1(input));
            setField0(result, getField0(input));
            setField2(result, (global::Orleans.Runtime.GrainReference)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField2(input)));
            setField3(result, (global::System.Object)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField3(input)));
            setField4(result, getField4(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Streams.PubSubSubscriptionState input = (global::Orleans.Streams.PubSubSubscriptionState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::Orleans.Streams.StreamId));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::Orleans.Runtime.GuidId));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (global::Orleans.Runtime.GrainReference));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), stream, typeof (global::System.Object));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), stream, typeof (global::Orleans.Streams.PubSubSubscriptionState.SubscriptionStates));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Streams.PubSubSubscriptionState result = (global::Orleans.Streams.PubSubSubscriptionState)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.PubSubSubscriptionState));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::Orleans.Streams.StreamId)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamId), stream));
            setField0(result, (global::Orleans.Runtime.GuidId)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.GuidId), stream));
            setField2(result, (global::Orleans.Runtime.GrainReference)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.GrainReference), stream));
            setField3(result, (global::System.Object)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Object), stream));
            setField4(result, (global::Orleans.Streams.PubSubSubscriptionState.SubscriptionStates)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.PubSubSubscriptionState.SubscriptionStates), stream));
            return (global::Orleans.Streams.PubSubSubscriptionState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Streams.PubSubSubscriptionState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Streams_PubSubSubscriptionStateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.StreamImpl<>))]
    internal class OrleansCodeGenOrleans_Streams_StreamImplSerializer<T>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Streams.StreamImpl<T>).@GetField("isRewindable", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamImpl<T>, global::System.Boolean> getField1 = (global::System.Func<global::Orleans.Streams.StreamImpl<T>, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Streams.StreamImpl<T>, global::System.Boolean> setField1 = (global::System.Action<global::Orleans.Streams.StreamImpl<T>, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.StreamImpl<T>).@GetField("streamId", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamImpl<T>, global::Orleans.Streams.StreamId> getField0 = (global::System.Func<global::Orleans.Streams.StreamImpl<T>, global::Orleans.Streams.StreamId>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Streams.StreamImpl<T>, global::Orleans.Streams.StreamId> setField0 = (global::System.Action<global::Orleans.Streams.StreamImpl<T>, global::Orleans.Streams.StreamId>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            return original;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Streams.StreamImpl<T> input = (global::Orleans.Streams.StreamImpl<T>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::Orleans.Streams.StreamId));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Streams.StreamImpl<T> result = new global::Orleans.Streams.StreamImpl<T>();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            setField0(result, (global::Orleans.Streams.StreamId)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamId), stream));
            return (global::Orleans.Streams.StreamImpl<T>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Streams_StreamImplSerializer_T_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Streams.StreamImpl<>), typeof (OrleansCodeGenOrleans_Streams_StreamImplSerializer<>));
        }

        static OrleansCodeGenOrleans_Streams_StreamImplSerializer_T_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.StreamConsumerData)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Streams_StreamConsumerDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Streams.StreamConsumerData).@GetField("Cursor", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.IQueueCacheCursor> getField4 = (global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.IQueueCacheCursor>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.IQueueCacheCursor> setField4 = (global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.IQueueCacheCursor>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Orleans.Streams.StreamConsumerData).@GetField("Filter", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.IStreamFilterPredicateWrapper> getField5 = (global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.IStreamFilterPredicateWrapper>)global::Orleans.Serialization.SerializationManager.@GetGetter(field5);
        private static readonly global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.IStreamFilterPredicateWrapper> setField5 = (global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.IStreamFilterPredicateWrapper>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Orleans.Streams.StreamConsumerData).@GetField("LastToken", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.StreamHandshakeToken> getField6 = (global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.StreamHandshakeToken>)global::Orleans.Serialization.SerializationManager.@GetGetter(field6);
        private static readonly global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.StreamHandshakeToken> setField6 = (global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.StreamHandshakeToken>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field6);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Streams.StreamConsumerData).@GetField("State", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.StreamConsumerDataState> getField3 = (global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.StreamConsumerDataState>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.StreamConsumerDataState> setField3 = (global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.StreamConsumerDataState>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Streams.StreamConsumerData).@GetField("StreamConsumer", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.IStreamConsumerExtension> getField2 = (global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.IStreamConsumerExtension>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.IStreamConsumerExtension> setField2 = (global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.IStreamConsumerExtension>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Streams.StreamConsumerData).@GetField("StreamId", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.StreamId> getField1 = (global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.StreamId>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.StreamId> setField1 = (global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Streams.StreamId>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.StreamConsumerData).@GetField("SubscriptionId", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Runtime.GuidId> getField0 = (global::System.Func<global::Orleans.Streams.StreamConsumerData, global::Orleans.Runtime.GuidId>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Runtime.GuidId> setField0 = (global::System.Action<global::Orleans.Streams.StreamConsumerData, global::Orleans.Runtime.GuidId>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Streams.StreamConsumerData input = ((global::Orleans.Streams.StreamConsumerData)original);
            global::Orleans.Streams.StreamConsumerData result = (global::Orleans.Streams.StreamConsumerData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.StreamConsumerData));
            setField4(result, (global::Orleans.Streams.IQueueCacheCursor)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField4(input)));
            setField5(result, (global::Orleans.Streams.IStreamFilterPredicateWrapper)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField5(input)));
            setField6(result, (global::Orleans.Streams.StreamHandshakeToken)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField6(input)));
            setField3(result, getField3(input));
            setField2(result, (global::Orleans.Streams.IStreamConsumerExtension)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField2(input)));
            setField1(result, getField1(input));
            setField0(result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Streams.StreamConsumerData input = (global::Orleans.Streams.StreamConsumerData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), stream, typeof (global::Orleans.Streams.IQueueCacheCursor));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField5(input), stream, typeof (global::Orleans.Streams.IStreamFilterPredicateWrapper));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField6(input), stream, typeof (global::Orleans.Streams.StreamHandshakeToken));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), stream, typeof (global::Orleans.Streams.StreamConsumerDataState));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (global::Orleans.Streams.IStreamConsumerExtension));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::Orleans.Streams.StreamId));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::Orleans.Runtime.GuidId));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Streams.StreamConsumerData result = (global::Orleans.Streams.StreamConsumerData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.StreamConsumerData));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField4(result, (global::Orleans.Streams.IQueueCacheCursor)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.IQueueCacheCursor), stream));
            setField5(result, (global::Orleans.Streams.IStreamFilterPredicateWrapper)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.IStreamFilterPredicateWrapper), stream));
            setField6(result, (global::Orleans.Streams.StreamHandshakeToken)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamHandshakeToken), stream));
            setField3(result, (global::Orleans.Streams.StreamConsumerDataState)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamConsumerDataState), stream));
            setField2(result, (global::Orleans.Streams.IStreamConsumerExtension)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.IStreamConsumerExtension), stream));
            setField1(result, (global::Orleans.Streams.StreamId)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamId), stream));
            setField0(result, (global::Orleans.Runtime.GuidId)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.GuidId), stream));
            return (global::Orleans.Streams.StreamConsumerData)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Streams.StreamConsumerData), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Streams_StreamConsumerDataSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.QueueId)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Streams_QueueIdSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Streams.QueueId).@GetField("queueId", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.QueueId, global::System.UInt32> getField1 = (global::System.Func<global::Orleans.Streams.QueueId, global::System.UInt32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Streams.QueueId, global::System.UInt32> setField1 = (global::System.Action<global::Orleans.Streams.QueueId, global::System.UInt32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.QueueId).@GetField("queueNamePrefix", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.QueueId, global::System.String> getField0 = (global::System.Func<global::Orleans.Streams.QueueId, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Streams.QueueId, global::System.String> setField0 = (global::System.Action<global::Orleans.Streams.QueueId, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Streams.QueueId).@GetField("uniformHashCache", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.QueueId, global::System.UInt32> getField2 = (global::System.Func<global::Orleans.Streams.QueueId, global::System.UInt32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Streams.QueueId, global::System.UInt32> setField2 = (global::System.Action<global::Orleans.Streams.QueueId, global::System.UInt32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            return original;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Streams.QueueId input = (global::Orleans.Streams.QueueId)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (global::System.UInt32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Streams.QueueId result = (global::Orleans.Streams.QueueId)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.QueueId));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField2(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            return (global::Orleans.Streams.QueueId)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Streams.QueueId), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Streams_QueueIdSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.StreamId)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Streams_StreamIdSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.StreamId).@GetField("key", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamId, global::Orleans.Streams.StreamIdInternerKey> getField0 = (global::System.Func<global::Orleans.Streams.StreamId, global::Orleans.Streams.StreamIdInternerKey>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Streams.StreamId, global::Orleans.Streams.StreamIdInternerKey> setField0 = (global::System.Action<global::Orleans.Streams.StreamId, global::Orleans.Streams.StreamIdInternerKey>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            return original;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Streams.StreamId input = (global::Orleans.Streams.StreamId)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::Orleans.Streams.StreamIdInternerKey));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Streams.StreamId result = (global::Orleans.Streams.StreamId)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Streams.StreamId));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::Orleans.Streams.StreamIdInternerKey)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamIdInternerKey), stream));
            return (global::Orleans.Streams.StreamId)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Streams.StreamId), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Streams_StreamIdSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Streams.StreamIdInternerKey)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Streams_StreamIdInternerKeySerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Streams.StreamIdInternerKey).@GetField("Guid", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamIdInternerKey, global::System.Guid> getField0 = (global::System.Func<global::Orleans.Streams.StreamIdInternerKey, global::System.Guid>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Streams.StreamIdInternerKey, global::System.Guid> setField0 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Streams.StreamIdInternerKey, global::System.Guid>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Streams.StreamIdInternerKey).@GetField("Namespace", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamIdInternerKey, global::System.String> getField2 = (global::System.Func<global::Orleans.Streams.StreamIdInternerKey, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Streams.StreamIdInternerKey, global::System.String> setField2 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Streams.StreamIdInternerKey, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Streams.StreamIdInternerKey).@GetField("ProviderName", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Streams.StreamIdInternerKey, global::System.String> getField1 = (global::System.Func<global::Orleans.Streams.StreamIdInternerKey, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Streams.StreamIdInternerKey, global::System.String> setField1 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Streams.StreamIdInternerKey, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            return original;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Streams.StreamIdInternerKey input = (global::Orleans.Streams.StreamIdInternerKey)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Guid));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Streams.StreamIdInternerKey result = default (global::Orleans.Streams.StreamIdInternerKey);
            setField0(ref result, (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Guid), stream));
            setField2(ref result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField1(ref result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            return (global::Orleans.Streams.StreamIdInternerKey)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Streams.StreamIdInternerKey), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Streams_StreamIdInternerKeySerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.GrainDirectory.AddressAndTag)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_GrainDirectory_AddressAndTagSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.GrainDirectory.AddressAndTag).@GetField("Address", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.GrainDirectory.AddressAndTag, global::Orleans.Runtime.ActivationAddress> getField0 = (global::System.Func<global::Orleans.GrainDirectory.AddressAndTag, global::Orleans.Runtime.ActivationAddress>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.GrainDirectory.AddressAndTag, global::Orleans.Runtime.ActivationAddress> setField0 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.GrainDirectory.AddressAndTag, global::Orleans.Runtime.ActivationAddress>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.GrainDirectory.AddressAndTag).@GetField("VersionTag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.GrainDirectory.AddressAndTag, global::System.Int32> getField1 = (global::System.Func<global::Orleans.GrainDirectory.AddressAndTag, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.GrainDirectory.AddressAndTag, global::System.Int32> setField1 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.GrainDirectory.AddressAndTag, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.GrainDirectory.AddressAndTag input = ((global::Orleans.GrainDirectory.AddressAndTag)original);
            global::Orleans.GrainDirectory.AddressAndTag result = default (global::Orleans.GrainDirectory.AddressAndTag);
            setField0(ref result, (global::Orleans.Runtime.ActivationAddress)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            setField1(ref result, getField1(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.GrainDirectory.AddressAndTag input = (global::Orleans.GrainDirectory.AddressAndTag)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::Orleans.Runtime.ActivationAddress));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.GrainDirectory.AddressAndTag result = default (global::Orleans.GrainDirectory.AddressAndTag);
            setField0(ref result, (global::Orleans.Runtime.ActivationAddress)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.ActivationAddress), stream));
            setField1(ref result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            return (global::Orleans.GrainDirectory.AddressAndTag)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.GrainDirectory.AddressAndTag), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_GrainDirectory_AddressAndTagSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.GrainDirectory.ClusterLocalRegistration)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_GrainDirectory_ClusterLocalRegistrationSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.GrainDirectory.ClusterLocalRegistration input = ((global::Orleans.GrainDirectory.ClusterLocalRegistration)original);
            global::Orleans.GrainDirectory.ClusterLocalRegistration result = (global::Orleans.GrainDirectory.ClusterLocalRegistration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.GrainDirectory.ClusterLocalRegistration));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.GrainDirectory.ClusterLocalRegistration input = (global::Orleans.GrainDirectory.ClusterLocalRegistration)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.GrainDirectory.ClusterLocalRegistration result = (global::Orleans.GrainDirectory.ClusterLocalRegistration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.GrainDirectory.ClusterLocalRegistration));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Orleans.GrainDirectory.ClusterLocalRegistration)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.GrainDirectory.ClusterLocalRegistration), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_GrainDirectory_ClusterLocalRegistrationSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.GuidId)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_GuidIdSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.GuidId).@GetField("Guid", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GuidId, global::System.Guid> getField0 = (global::System.Func<global::Orleans.Runtime.GuidId, global::System.Guid>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.GuidId, global::System.Guid> setField0 = (global::System.Action<global::Orleans.Runtime.GuidId, global::System.Guid>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            return original;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.GuidId input = (global::Orleans.Runtime.GuidId)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Guid));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.GuidId result = (global::Orleans.Runtime.GuidId)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.GuidId));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Guid), stream));
            return (global::Orleans.Runtime.GuidId)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.GuidId), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_GuidIdSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.RequestInvocationHistory)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_RequestInvocationHistorySerializer
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.RequestInvocationHistory).@GetField("<ActivationId>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.RequestInvocationHistory, global::Orleans.Runtime.ActivationId> setField1 = (global::System.Action<global::Orleans.Runtime.RequestInvocationHistory, global::Orleans.Runtime.ActivationId>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.RequestInvocationHistory).@GetField("<DebugContext>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.RequestInvocationHistory, global::System.String> setField2 = (global::System.Action<global::Orleans.Runtime.RequestInvocationHistory, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.RequestInvocationHistory).@GetField("<GrainId>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.RequestInvocationHistory, global::Orleans.Runtime.GrainId> setField0 = (global::System.Action<global::Orleans.Runtime.RequestInvocationHistory, global::Orleans.Runtime.GrainId>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.RequestInvocationHistory input = ((global::Orleans.Runtime.RequestInvocationHistory)original);
            global::Orleans.Runtime.RequestInvocationHistory result = (global::Orleans.Runtime.RequestInvocationHistory)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.RequestInvocationHistory));
            setField1(result, (global::Orleans.Runtime.ActivationId)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@ActivationId));
            setField2(result, input.@DebugContext);
            setField0(result, (global::Orleans.Runtime.GrainId)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@GrainId));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.RequestInvocationHistory input = (global::Orleans.Runtime.RequestInvocationHistory)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ActivationId, stream, typeof (global::Orleans.Runtime.ActivationId));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DebugContext, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GrainId, stream, typeof (global::Orleans.Runtime.GrainId));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.RequestInvocationHistory result = (global::Orleans.Runtime.RequestInvocationHistory)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.RequestInvocationHistory));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::Orleans.Runtime.ActivationId)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.ActivationId), stream));
            setField2(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField0(result, (global::Orleans.Runtime.GrainId)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.GrainId), stream));
            return (global::Orleans.Runtime.RequestInvocationHistory)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.RequestInvocationHistory), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_RequestInvocationHistorySerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.PreferLocalPlacement)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_PreferLocalPlacementSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.PreferLocalPlacement input = ((global::Orleans.Runtime.PreferLocalPlacement)original);
            global::Orleans.Runtime.PreferLocalPlacement result = (global::Orleans.Runtime.PreferLocalPlacement)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.PreferLocalPlacement));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.PreferLocalPlacement input = (global::Orleans.Runtime.PreferLocalPlacement)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.PreferLocalPlacement result = (global::Orleans.Runtime.PreferLocalPlacement)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.PreferLocalPlacement));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Orleans.Runtime.PreferLocalPlacement)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.PreferLocalPlacement), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_PreferLocalPlacementSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.UniqueKey)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_UniqueKeySerializer
    {
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Runtime.UniqueKey).@GetField("<KeyExt>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.UniqueKey, global::System.String> setField3 = (global::System.Action<global::Orleans.Runtime.UniqueKey, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.UniqueKey).@GetField("<N0>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.UniqueKey, global::System.UInt64> setField0 = (global::System.Action<global::Orleans.Runtime.UniqueKey, global::System.UInt64>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.UniqueKey).@GetField("<N1>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.UniqueKey, global::System.UInt64> setField1 = (global::System.Action<global::Orleans.Runtime.UniqueKey, global::System.UInt64>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.UniqueKey).@GetField("<TypeCodeData>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.UniqueKey, global::System.UInt64> setField2 = (global::System.Action<global::Orleans.Runtime.UniqueKey, global::System.UInt64>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.UniqueKey input = ((global::Orleans.Runtime.UniqueKey)original);
            global::Orleans.Runtime.UniqueKey result = new global::Orleans.Runtime.UniqueKey();
            setField3(result, input.@KeyExt);
            setField0(result, input.@N0);
            setField1(result, input.@N1);
            setField2(result, input.@TypeCodeData);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.UniqueKey input = (global::Orleans.Runtime.UniqueKey)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@KeyExt, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@N0, stream, typeof (global::System.UInt64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@N1, stream, typeof (global::System.UInt64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TypeCodeData, stream, typeof (global::System.UInt64));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.UniqueKey result = new global::Orleans.Runtime.UniqueKey();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField3(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField0(result, (global::System.UInt64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt64), stream));
            setField1(result, (global::System.UInt64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt64), stream));
            setField2(result, (global::System.UInt64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt64), stream));
            return (global::Orleans.Runtime.UniqueKey)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.UniqueKey), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_UniqueKeySerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.SingleRange)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_SingleRangeSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.SingleRange).@GetField("begin", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.SingleRange, global::System.UInt32> getField0 = (global::System.Func<global::Orleans.Runtime.SingleRange, global::System.UInt32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.SingleRange, global::System.UInt32> setField0 = (global::System.Action<global::Orleans.Runtime.SingleRange, global::System.UInt32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.SingleRange).@GetField("end", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.SingleRange, global::System.UInt32> getField1 = (global::System.Func<global::Orleans.Runtime.SingleRange, global::System.UInt32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.SingleRange, global::System.UInt32> setField1 = (global::System.Action<global::Orleans.Runtime.SingleRange, global::System.UInt32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.SingleRange input = ((global::Orleans.Runtime.SingleRange)original);
            global::Orleans.Runtime.SingleRange result = (global::Orleans.Runtime.SingleRange)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.SingleRange));
            setField0(result, getField0(input));
            setField1(result, getField1(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.SingleRange input = (global::Orleans.Runtime.SingleRange)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.UInt32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.UInt32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.SingleRange result = (global::Orleans.Runtime.SingleRange)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.SingleRange));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            setField1(result, (global::System.UInt32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UInt32), stream));
            return (global::Orleans.Runtime.SingleRange)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.SingleRange), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_SingleRangeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.ActivationCountBasedPlacement)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_ActivationCountBasedPlacementSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.ActivationCountBasedPlacement input = ((global::Orleans.Runtime.ActivationCountBasedPlacement)original);
            global::Orleans.Runtime.ActivationCountBasedPlacement result = (global::Orleans.Runtime.ActivationCountBasedPlacement)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.ActivationCountBasedPlacement));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.ActivationCountBasedPlacement input = (global::Orleans.Runtime.ActivationCountBasedPlacement)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.ActivationCountBasedPlacement result = (global::Orleans.Runtime.ActivationCountBasedPlacement)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.ActivationCountBasedPlacement));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Orleans.Runtime.ActivationCountBasedPlacement)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.ActivationCountBasedPlacement), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_ActivationCountBasedPlacementSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.StatelessWorkerPlacement)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_StatelessWorkerPlacementSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.StatelessWorkerPlacement).@GetField("<MaxLocal>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.StatelessWorkerPlacement, global::System.Int32> setField0 = (global::System.Action<global::Orleans.Runtime.StatelessWorkerPlacement, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.StatelessWorkerPlacement input = ((global::Orleans.Runtime.StatelessWorkerPlacement)original);
            global::Orleans.Runtime.StatelessWorkerPlacement result = (global::Orleans.Runtime.StatelessWorkerPlacement)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.StatelessWorkerPlacement));
            setField0(result, input.@MaxLocal);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.StatelessWorkerPlacement input = (global::Orleans.Runtime.StatelessWorkerPlacement)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxLocal, stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.StatelessWorkerPlacement result = (global::Orleans.Runtime.StatelessWorkerPlacement)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.StatelessWorkerPlacement));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            return (global::Orleans.Runtime.StatelessWorkerPlacement)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.StatelessWorkerPlacement), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_StatelessWorkerPlacementSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.RandomPlacement)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_RandomPlacementSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.RandomPlacement input = ((global::Orleans.Runtime.RandomPlacement)original);
            global::Orleans.Runtime.RandomPlacement result = (global::Orleans.Runtime.RandomPlacement)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.RandomPlacement));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.RandomPlacement input = (global::Orleans.Runtime.RandomPlacement)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.RandomPlacement result = (global::Orleans.Runtime.RandomPlacement)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.RandomPlacement));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Orleans.Runtime.RandomPlacement)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.RandomPlacement), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_RandomPlacementSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.SystemPlacement)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_SystemPlacementSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.SystemPlacement input = ((global::Orleans.Runtime.SystemPlacement)original);
            global::Orleans.Runtime.SystemPlacement result = (global::Orleans.Runtime.SystemPlacement)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.SystemPlacement));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.SystemPlacement input = (global::Orleans.Runtime.SystemPlacement)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.SystemPlacement result = (global::Orleans.Runtime.SystemPlacement)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.SystemPlacement));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Orleans.Runtime.SystemPlacement)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.SystemPlacement), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_SystemPlacementSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.GrainClassData)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_GrainClassDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Runtime.GrainClassData).@GetField("<GrainClass>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainClassData, global::System.String> getField4 = (global::System.Func<global::Orleans.Runtime.GrainClassData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainClassData, global::System.String> setField4 = (global::System.Action<global::Orleans.Runtime.GrainClassData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Runtime.GrainClassData).@GetField("<GrainTypeCode>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainClassData, global::System.Int32> getField3 = (global::System.Func<global::Orleans.Runtime.GrainClassData, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainClassData, global::System.Int32> setField3 = (global::System.Action<global::Orleans.Runtime.GrainClassData, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.GrainClassData).@GetField("isGeneric", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainClassData, global::System.Boolean> getField2 = (global::System.Func<global::Orleans.Runtime.GrainClassData, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainClassData, global::System.Boolean> setField2 = (global::System.Action<global::Orleans.Runtime.GrainClassData, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.GrainClassData).@GetField("placementStrategy", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainClassData, global::Orleans.Runtime.PlacementStrategy> getField0 = (global::System.Func<global::Orleans.Runtime.GrainClassData, global::Orleans.Runtime.PlacementStrategy>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainClassData, global::Orleans.Runtime.PlacementStrategy> setField0 = (global::System.Action<global::Orleans.Runtime.GrainClassData, global::Orleans.Runtime.PlacementStrategy>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.GrainClassData).@GetField("registrationStrategy", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainClassData, global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy> getField1 = (global::System.Func<global::Orleans.Runtime.GrainClassData, global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainClassData, global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy> setField1 = (global::System.Action<global::Orleans.Runtime.GrainClassData, global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.GrainClassData input = ((global::Orleans.Runtime.GrainClassData)original);
            global::Orleans.Runtime.GrainClassData result = (global::Orleans.Runtime.GrainClassData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.GrainClassData));
            setField4(result, getField4(input));
            setField3(result, getField3(input));
            setField2(result, getField2(input));
            setField0(result, (global::Orleans.Runtime.PlacementStrategy)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            setField1(result, (global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.GrainClassData input = (global::Orleans.Runtime.GrainClassData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::Orleans.Runtime.PlacementStrategy));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.GrainClassData result = (global::Orleans.Runtime.GrainClassData)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.GrainClassData));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField4(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField3(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField2(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            setField0(result, (global::Orleans.Runtime.PlacementStrategy)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.PlacementStrategy), stream));
            setField1(result, (global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.GrainDirectory.MultiClusterRegistrationStrategy), stream));
            return (global::Orleans.Runtime.GrainClassData)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.GrainClassData), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_GrainClassDataSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.TickStatus)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_TickStatusSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.TickStatus).@GetField("<CurrentTickTime>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Runtime.TickStatus, global::System.DateTime> setField2 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Runtime.TickStatus, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.TickStatus).@GetField("<FirstTickTime>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Runtime.TickStatus, global::System.DateTime> setField0 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Runtime.TickStatus, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.TickStatus).@GetField("<Period>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Runtime.TickStatus, global::System.TimeSpan> setField1 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::Orleans.Runtime.TickStatus, global::System.TimeSpan>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.TickStatus input = ((global::Orleans.Runtime.TickStatus)original);
            global::Orleans.Runtime.TickStatus result = default (global::Orleans.Runtime.TickStatus);
            setField2(ref result, input.@CurrentTickTime);
            setField0(ref result, input.@FirstTickTime);
            setField1(ref result, input.@Period);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.TickStatus input = (global::Orleans.Runtime.TickStatus)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@CurrentTickTime, stream, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@FirstTickTime, stream, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Period, stream, typeof (global::System.TimeSpan));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.TickStatus result = default (global::Orleans.Runtime.TickStatus);
            setField2(ref result, (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), stream));
            setField0(ref result, (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), stream));
            setField1(ref result, (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream));
            return (global::Orleans.Runtime.TickStatus)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.TickStatus), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_TickStatusSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.SiloRuntimeStatistics)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_SiloRuntimeStatisticsSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetField("<ActivationCount>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int32> setField0 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetField("<AvailableMemory>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Single> setField6 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Single>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field6);
        private static readonly global::System.Reflection.FieldInfo field10 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetField("<ClientCount>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int64> setField10 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field10);
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetField("<CpuUsage>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Single> setField5 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Single>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        private static readonly global::System.Reflection.FieldInfo field13 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetField("<DateTime>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.DateTime> setField13 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field13);
        private static readonly global::System.Reflection.FieldInfo field9 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetField("<IsOverloaded>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Boolean> setField9 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field9);
        private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetField("<MemoryUsage>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int64> setField7 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field7);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetField("<ReceiveQueueLength>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int32> setField4 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field11 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetField("<ReceivedMessages>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int64> setField11 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field11);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetField("<RecentlyUsedActivationCount>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int32> setField1 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetField("<RequestQueueLength>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int64> setField2 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetField("<SendQueueLength>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int32> setField3 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field12 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetField("<SentMessages>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int64> setField12 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field12);
        private static readonly global::System.Reflection.FieldInfo field8 = typeof (global::Orleans.Runtime.SiloRuntimeStatistics).@GetField("<TotalPhysicalMemory>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int64> setField8 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field8);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.SiloRuntimeStatistics input = ((global::Orleans.Runtime.SiloRuntimeStatistics)original);
            global::Orleans.Runtime.SiloRuntimeStatistics result = (global::Orleans.Runtime.SiloRuntimeStatistics)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.SiloRuntimeStatistics));
            setField0(result, input.@ActivationCount);
            setField6(result, input.@AvailableMemory);
            setField10(result, input.@ClientCount);
            setField5(result, input.@CpuUsage);
            setField13(result, input.@DateTime);
            setField9(result, input.@IsOverloaded);
            setField7(result, input.@MemoryUsage);
            setField4(result, input.@ReceiveQueueLength);
            setField11(result, input.@ReceivedMessages);
            setField1(result, input.@RecentlyUsedActivationCount);
            setField2(result, input.@RequestQueueLength);
            setField3(result, input.@SendQueueLength);
            setField12(result, input.@SentMessages);
            setField8(result, input.@TotalPhysicalMemory);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.SiloRuntimeStatistics input = (global::Orleans.Runtime.SiloRuntimeStatistics)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ActivationCount, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@AvailableMemory, stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ClientCount, stream, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@CpuUsage, stream, typeof (global::System.Single));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DateTime, stream, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@IsOverloaded, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MemoryUsage, stream, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ReceiveQueueLength, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ReceivedMessages, stream, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@RecentlyUsedActivationCount, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@RequestQueueLength, stream, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SendQueueLength, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SentMessages, stream, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TotalPhysicalMemory, stream, typeof (global::System.Int64));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.SiloRuntimeStatistics result = (global::Orleans.Runtime.SiloRuntimeStatistics)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.SiloRuntimeStatistics));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField6(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            setField10(result, (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), stream));
            setField5(result, (global::System.Single)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Single), stream));
            setField13(result, (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), stream));
            setField9(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            setField7(result, (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), stream));
            setField4(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField11(result, (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), stream));
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField2(result, (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), stream));
            setField3(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField12(result, (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), stream));
            setField8(result, (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), stream));
            return (global::Orleans.Runtime.SiloRuntimeStatistics)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.SiloRuntimeStatistics), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_SiloRuntimeStatisticsSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.GrainStatistic)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_GrainStatisticSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.GrainStatistic input = ((global::Orleans.Runtime.GrainStatistic)original);
            global::Orleans.Runtime.GrainStatistic result = new global::Orleans.Runtime.GrainStatistic();
            result.@ActivationCount = input.@ActivationCount;
            result.@GrainCount = input.@GrainCount;
            result.@GrainType = input.@GrainType;
            result.@SiloCount = input.@SiloCount;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.GrainStatistic input = (global::Orleans.Runtime.GrainStatistic)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ActivationCount, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GrainCount, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GrainType, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SiloCount, stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.GrainStatistic result = new global::Orleans.Runtime.GrainStatistic();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@ActivationCount = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@GrainCount = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@GrainType = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@SiloCount = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            return (global::Orleans.Runtime.GrainStatistic)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.GrainStatistic), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_GrainStatisticSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.SimpleGrainStatistic)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_SimpleGrainStatisticSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.SimpleGrainStatistic input = ((global::Orleans.Runtime.SimpleGrainStatistic)original);
            global::Orleans.Runtime.SimpleGrainStatistic result = new global::Orleans.Runtime.SimpleGrainStatistic();
            result.@ActivationCount = input.@ActivationCount;
            result.@GrainType = input.@GrainType;
            result.@SiloAddress = (global::Orleans.Runtime.SiloAddress)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@SiloAddress);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.SimpleGrainStatistic input = (global::Orleans.Runtime.SimpleGrainStatistic)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ActivationCount, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GrainType, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SiloAddress, stream, typeof (global::Orleans.Runtime.SiloAddress));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.SimpleGrainStatistic result = new global::Orleans.Runtime.SimpleGrainStatistic();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@ActivationCount = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@GrainType = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@SiloAddress = (global::Orleans.Runtime.SiloAddress)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.SiloAddress), stream);
            return (global::Orleans.Runtime.SimpleGrainStatistic)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.SimpleGrainStatistic), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_SimpleGrainStatisticSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.LimitValue)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_LimitValueSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.Configuration.LimitValue input = ((global::Orleans.Runtime.Configuration.LimitValue)original);
            global::Orleans.Runtime.Configuration.LimitValue result = new global::Orleans.Runtime.Configuration.LimitValue();
            result.@HardLimitThreshold = input.@HardLimitThreshold;
            result.@Name = input.@Name;
            result.@SoftLimitThreshold = input.@SoftLimitThreshold;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.LimitValue input = (global::Orleans.Runtime.Configuration.LimitValue)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@HardLimitThreshold, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Name, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SoftLimitThreshold, stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.Configuration.LimitValue result = new global::Orleans.Runtime.Configuration.LimitValue();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@HardLimitThreshold = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@Name = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@SoftLimitThreshold = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            return (global::Orleans.Runtime.Configuration.LimitValue)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.Configuration.LimitValue), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_Configuration_LimitValueSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_MessagingConfigurationSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field18 = typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration).@GetField("<MessageLossInjectionRate>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double> getField18 = (global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double>)global::Orleans.Serialization.SerializationManager.@GetGetter(field18);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double> setField18 = (global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field18);
        private static readonly global::System.Reflection.FieldInfo field17 = typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration).@GetField("<RejectionInjectionRate>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double> getField17 = (global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double>)global::Orleans.Serialization.SerializationManager.@GetGetter(field17);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double> setField17 = (global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field17);
        private static readonly global::System.Reflection.FieldInfo field16 = typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration).@GetField("<SerializationProviders>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>> setField16 = (global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field16);
        private static readonly global::System.Reflection.FieldInfo field19 = typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration).@GetField("isSiloConfig", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Boolean> getField19 = (global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field19);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Boolean> setField19 = (global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field19);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.Configuration.MessagingConfiguration input = ((global::Orleans.Runtime.Configuration.MessagingConfiguration)original);
            global::Orleans.Runtime.Configuration.MessagingConfiguration result = (global::Orleans.Runtime.Configuration.MessagingConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration));
            result.@BufferPoolBufferSize = input.@BufferPoolBufferSize;
            result.@BufferPoolMaxSize = input.@BufferPoolMaxSize;
            result.@BufferPoolPreallocationSize = input.@BufferPoolPreallocationSize;
            result.@ClientSenderBuckets = input.@ClientSenderBuckets;
            result.@DropExpiredMessages = input.@DropExpiredMessages;
            result.@GatewaySenderQueues = input.@GatewaySenderQueues;
            result.@MaxForwardCount = input.@MaxForwardCount;
            result.@MaxMessageBatchingSize = input.@MaxMessageBatchingSize;
            result.@MaxResendCount = input.@MaxResendCount;
            result.@MaxSocketAge = input.@MaxSocketAge;
            setField18(result, getField18(input));
            setField17(result, getField17(input));
            result.@ResendOnTimeout = input.@ResendOnTimeout;
            result.@ResponseTimeout = input.@ResponseTimeout;
            setField16(result, (global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@SerializationProviders));
            result.@SiloSenderQueues = input.@SiloSenderQueues;
            result.@UseJsonFallbackSerializer = input.@UseJsonFallbackSerializer;
            result.@UseMessageBatching = input.@UseMessageBatching;
            result.@UseStandardSerializer = input.@UseStandardSerializer;
            setField19(result, getField19(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.MessagingConfiguration input = (global::Orleans.Runtime.Configuration.MessagingConfiguration)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@BufferPoolBufferSize, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@BufferPoolMaxSize, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@BufferPoolPreallocationSize, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ClientSenderBuckets, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DropExpiredMessages, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GatewaySenderQueues, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxForwardCount, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxMessageBatchingSize, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxResendCount, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxSocketAge, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField18(input), stream, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField17(input), stream, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ResendOnTimeout, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ResponseTimeout, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SerializationProviders, stream, typeof (global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SiloSenderQueues, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@UseJsonFallbackSerializer, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@UseMessageBatching, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@UseStandardSerializer, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField19(input), stream, typeof (global::System.Boolean));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.Configuration.MessagingConfiguration result = (global::Orleans.Runtime.Configuration.MessagingConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@BufferPoolBufferSize = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@BufferPoolMaxSize = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@BufferPoolPreallocationSize = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@ClientSenderBuckets = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@DropExpiredMessages = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            result.@GatewaySenderQueues = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@MaxForwardCount = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@MaxMessageBatchingSize = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@MaxResendCount = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@MaxSocketAge = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream);
            setField18(result, (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), stream));
            setField17(result, (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), stream));
            result.@ResendOnTimeout = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            result.@ResponseTimeout = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream);
            setField16(result, (global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>), stream));
            result.@SiloSenderQueues = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@UseJsonFallbackSerializer = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            result.@UseMessageBatching = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            result.@UseStandardSerializer = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            setField19(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            return (global::Orleans.Runtime.Configuration.MessagingConfiguration)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_Configuration_MessagingConfigurationSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.ProviderConfiguration)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_ProviderConfigurationSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Runtime.Configuration.ProviderConfiguration).@GetField("<Name>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.String> setField3 = (global::System.Action<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.Configuration.ProviderConfiguration).@GetField("<Type>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.String> setField2 = (global::System.Action<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.Configuration.ProviderConfiguration).@GetField("childConfigurations", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.Collections.Generic.IList<global::Orleans.Runtime.Configuration.ProviderConfiguration>> getField1 = (global::System.Func<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.Collections.Generic.IList<global::Orleans.Runtime.Configuration.ProviderConfiguration>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.Collections.Generic.IList<global::Orleans.Runtime.Configuration.ProviderConfiguration>> setField1 = (global::System.Action<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.Collections.Generic.IList<global::Orleans.Runtime.Configuration.ProviderConfiguration>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.Configuration.ProviderConfiguration).@GetField("properties", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>> getField0 = (global::System.Func<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>> setField0 = (global::System.Action<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Runtime.Configuration.ProviderConfiguration).@GetField("readonlyCopyOfProperties", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.Collections.ObjectModel.ReadOnlyDictionary<global::System.String, global::System.String>> getField4 = (global::System.Func<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.Collections.ObjectModel.ReadOnlyDictionary<global::System.String, global::System.String>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.Collections.ObjectModel.ReadOnlyDictionary<global::System.String, global::System.String>> setField4 = (global::System.Action<global::Orleans.Runtime.Configuration.ProviderConfiguration, global::System.Collections.ObjectModel.ReadOnlyDictionary<global::System.String, global::System.String>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.Configuration.ProviderConfiguration input = ((global::Orleans.Runtime.Configuration.ProviderConfiguration)original);
            global::Orleans.Runtime.Configuration.ProviderConfiguration result = (global::Orleans.Runtime.Configuration.ProviderConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.ProviderConfiguration));
            setField3(result, input.@Name);
            setField2(result, input.@Type);
            setField1(result, (global::System.Collections.Generic.IList<global::Orleans.Runtime.Configuration.ProviderConfiguration>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input)));
            setField0(result, (global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            setField4(result, (global::System.Collections.ObjectModel.ReadOnlyDictionary<global::System.String, global::System.String>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField4(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.ProviderConfiguration input = (global::Orleans.Runtime.Configuration.ProviderConfiguration)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Name, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Type, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Collections.Generic.IList<global::Orleans.Runtime.Configuration.ProviderConfiguration>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), stream, typeof (global::System.Collections.ObjectModel.ReadOnlyDictionary<global::System.String, global::System.String>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.Configuration.ProviderConfiguration result = (global::Orleans.Runtime.Configuration.ProviderConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.ProviderConfiguration));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField3(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField2(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField1(result, (global::System.Collections.Generic.IList<global::Orleans.Runtime.Configuration.ProviderConfiguration>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IList<global::Orleans.Runtime.Configuration.ProviderConfiguration>), stream));
            setField0(result, (global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::System.String>), stream));
            setField4(result, (global::System.Collections.ObjectModel.ReadOnlyDictionary<global::System.String, global::System.String>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.ObjectModel.ReadOnlyDictionary<global::System.String, global::System.String>), stream));
            return (global::Orleans.Runtime.Configuration.ProviderConfiguration)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.Configuration.ProviderConfiguration), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_Configuration_ProviderConfigurationSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_ProviderCategoryConfigurationSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration input = ((global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration)original);
            global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration result = (global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration));
            result.@Name = input.@Name;
            result.@Providers = (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Providers.IProviderConfiguration>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Providers);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration input = (global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Name, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Providers, stream, typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Providers.IProviderConfiguration>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration result = (global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Name = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@Providers = (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Providers.IProviderConfiguration>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Providers.IProviderConfiguration>), stream);
            return (global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_Configuration_ProviderCategoryConfigurationSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.ApplicationConfiguration)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_ApplicationConfigurationSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.Configuration.ApplicationConfiguration).@GetField("classSpecific", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.ApplicationConfiguration, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.GrainTypeConfiguration>> getField0 = (global::System.Func<global::Orleans.Runtime.Configuration.ApplicationConfiguration, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.GrainTypeConfiguration>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ApplicationConfiguration, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.GrainTypeConfiguration>> setField0 = (global::System.Action<global::Orleans.Runtime.Configuration.ApplicationConfiguration, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.GrainTypeConfiguration>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.Configuration.ApplicationConfiguration).@GetField("defaults", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.ApplicationConfiguration, global::Orleans.Runtime.Configuration.GrainTypeConfiguration> getField1 = (global::System.Func<global::Orleans.Runtime.Configuration.ApplicationConfiguration, global::Orleans.Runtime.Configuration.GrainTypeConfiguration>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ApplicationConfiguration, global::Orleans.Runtime.Configuration.GrainTypeConfiguration> setField1 = (global::System.Action<global::Orleans.Runtime.Configuration.ApplicationConfiguration, global::Orleans.Runtime.Configuration.GrainTypeConfiguration>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.Configuration.ApplicationConfiguration input = ((global::Orleans.Runtime.Configuration.ApplicationConfiguration)original);
            global::Orleans.Runtime.Configuration.ApplicationConfiguration result = (global::Orleans.Runtime.Configuration.ApplicationConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.ApplicationConfiguration));
            setField0(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.GrainTypeConfiguration>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            setField1(result, (global::Orleans.Runtime.Configuration.GrainTypeConfiguration)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.ApplicationConfiguration input = (global::Orleans.Runtime.Configuration.ApplicationConfiguration)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.GrainTypeConfiguration>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::Orleans.Runtime.Configuration.GrainTypeConfiguration));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.Configuration.ApplicationConfiguration result = (global::Orleans.Runtime.Configuration.ApplicationConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.ApplicationConfiguration));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.GrainTypeConfiguration>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.GrainTypeConfiguration>), stream));
            setField1(result, (global::Orleans.Runtime.Configuration.GrainTypeConfiguration)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.GrainTypeConfiguration), stream));
            return (global::Orleans.Runtime.Configuration.ApplicationConfiguration)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.Configuration.ApplicationConfiguration), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_Configuration_ApplicationConfigurationSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.GrainTypeConfiguration)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_GrainTypeConfigurationSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.Configuration.GrainTypeConfiguration).@GetField("<FullTypeName>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GrainTypeConfiguration, global::System.String> setField0 = (global::System.Action<global::Orleans.Runtime.Configuration.GrainTypeConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.Configuration.GrainTypeConfiguration).@GetField("collectionAgeLimit", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.GrainTypeConfiguration, global::System.Nullable<global::System.TimeSpan>> getField1 = (global::System.Func<global::Orleans.Runtime.Configuration.GrainTypeConfiguration, global::System.Nullable<global::System.TimeSpan>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GrainTypeConfiguration, global::System.Nullable<global::System.TimeSpan>> setField1 = (global::System.Action<global::Orleans.Runtime.Configuration.GrainTypeConfiguration, global::System.Nullable<global::System.TimeSpan>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.Configuration.GrainTypeConfiguration input = ((global::Orleans.Runtime.Configuration.GrainTypeConfiguration)original);
            global::Orleans.Runtime.Configuration.GrainTypeConfiguration result = (global::Orleans.Runtime.Configuration.GrainTypeConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.GrainTypeConfiguration));
            setField0(result, input.@FullTypeName);
            setField1(result, (global::System.Nullable<global::System.TimeSpan>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.GrainTypeConfiguration input = (global::Orleans.Runtime.Configuration.GrainTypeConfiguration)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@FullTypeName, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Nullable<global::System.TimeSpan>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.Configuration.GrainTypeConfiguration result = (global::Orleans.Runtime.Configuration.GrainTypeConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.GrainTypeConfiguration));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField1(result, (global::System.Nullable<global::System.TimeSpan>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Nullable<global::System.TimeSpan>), stream));
            return (global::Orleans.Runtime.Configuration.GrainTypeConfiguration)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.Configuration.GrainTypeConfiguration), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_Configuration_GrainTypeConfigurationSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.LimitManager)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_LimitManagerSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.Configuration.LimitManager).@GetField("limitValues", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.LimitManager, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.LimitValue>> getField0 = (global::System.Func<global::Orleans.Runtime.Configuration.LimitManager, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.LimitValue>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.LimitManager, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.LimitValue>> setField0 = (global::System.Action<global::Orleans.Runtime.Configuration.LimitManager, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.LimitValue>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.Configuration.LimitManager input = ((global::Orleans.Runtime.Configuration.LimitManager)original);
            global::Orleans.Runtime.Configuration.LimitManager result = new global::Orleans.Runtime.Configuration.LimitManager();
            setField0(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.LimitValue>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.LimitManager input = (global::Orleans.Runtime.Configuration.LimitManager)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.LimitValue>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.Configuration.LimitManager result = new global::Orleans.Runtime.Configuration.LimitManager();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.LimitValue>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.Runtime.Configuration.LimitValue>), stream));
            return (global::Orleans.Runtime.Configuration.LimitManager)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.Configuration.LimitManager), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_Configuration_LimitManagerSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.ConfigValue<>))]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_ConfigValueSerializer<T>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.Configuration.ConfigValue<T>).@GetField("IsDefaultValue", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.ConfigValue<T>, global::System.Boolean> getField1 = (global::System.Func<global::Orleans.Runtime.Configuration.ConfigValue<T>, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ConfigValue<T>, global::System.Boolean> setField1 = (global::System.Action<global::Orleans.Runtime.Configuration.ConfigValue<T>, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.Configuration.ConfigValue<T>).@GetField("Value", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.ConfigValue<T>, T> getField0 = (global::System.Func<global::Orleans.Runtime.Configuration.ConfigValue<T>, T>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ConfigValue<T>, T> setField0 = (global::System.Action<global::Orleans.Runtime.Configuration.ConfigValue<T>, T>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.Configuration.ConfigValue<T> input = ((global::Orleans.Runtime.Configuration.ConfigValue<T>)original);
            global::Orleans.Runtime.Configuration.ConfigValue<T> result = (global::Orleans.Runtime.Configuration.ConfigValue<T>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.ConfigValue<T>));
            setField1(result, getField1(input));
            setField0(result, (T)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.ConfigValue<T> input = (global::Orleans.Runtime.Configuration.ConfigValue<T>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.Configuration.ConfigValue<T> result = (global::Orleans.Runtime.Configuration.ConfigValue<T>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.ConfigValue<T>));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            setField0(result, (T)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T), stream));
            return (global::Orleans.Runtime.Configuration.ConfigValue<T>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_ConfigValueSerializer_T_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.Configuration.ConfigValue<>), typeof (OrleansCodeGenOrleans_Runtime_Configuration_ConfigValueSerializer<>));
        }

        static OrleansCodeGenOrleans_Runtime_Configuration_ConfigValueSerializer_T_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_GlobalConfigurationSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration).@GetField("<Application>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.ApplicationConfiguration> setField0 = (global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.ApplicationConfiguration>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field19 = typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration).@GetField("<CollectionQuantum>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.TimeSpan> getField19 = (global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.TimeSpan>)global::Orleans.Serialization.SerializationManager.@GetGetter(field19);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.TimeSpan> setField19 = (global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.TimeSpan>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field19);
        private static readonly global::System.Reflection.FieldInfo field9 = typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration).@GetField("<ExpectedClusterSizeConfigValue>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.ConfigValue<global::System.Int32>> getField9 = (global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.ConfigValue<global::System.Int32>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field9);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.ConfigValue<global::System.Int32>> setField9 = (global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.ConfigValue<global::System.Int32>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field9);
        private static readonly global::System.Reflection.FieldInfo field24 = typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration).@GetField("<MaxStorageBusyRetries>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.Int32> setField24 = (global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field24);
        private static readonly global::System.Reflection.FieldInfo field62 = typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration).@GetField("<MessageLossInjectionRate>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double> getField62 = (global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double>)global::Orleans.Serialization.SerializationManager.@GetGetter(field62);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double> setField62 = (global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field62);
        private static readonly global::System.Reflection.FieldInfo field37 = typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration).@GetField("<PerformDeadlockDetection>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.Boolean> getField37 = (global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field37);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.Boolean> setField37 = (global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field37);
        private static readonly global::System.Reflection.FieldInfo field61 = typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration).@GetField("<RejectionInjectionRate>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double> getField61 = (global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double>)global::Orleans.Serialization.SerializationManager.@GetGetter(field61);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double> setField61 = (global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Double>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field61);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration).@GetField("<SeedNodes>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.Collections.Generic.IList<global::System.Net.IPEndPoint>> setField1 = (global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.Collections.Generic.IList<global::System.Net.IPEndPoint>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field60 = typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration).@GetField("<SerializationProviders>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>> setField60 = (global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field60);
        private static readonly global::System.Reflection.FieldInfo field33 = typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration).@GetField("UseMockReminderTable", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.Boolean> getField33 = (global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field33);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.Boolean> setField33 = (global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field33);
        private static readonly global::System.Reflection.FieldInfo field43 = typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration).@GetField("adoInvariantForReminders", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.String> getField43 = (global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field43);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.String> setField43 = (global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field43);
        private static readonly global::System.Reflection.FieldInfo field42 = typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration).@GetField("dataConnectionStringForReminders", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.String> getField42 = (global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field42);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.String> setField42 = (global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field42);
        private static readonly global::System.Reflection.FieldInfo field63 = typeof (global::Orleans.Runtime.Configuration.MessagingConfiguration).@GetField("isSiloConfig", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Boolean> getField63 = (global::System.Func<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field63);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Boolean> setField63 = (global::System.Action<global::Orleans.Runtime.Configuration.MessagingConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field63);
        private static readonly global::System.Reflection.FieldInfo field28 = typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration).@GetField("livenessServiceType", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.GlobalConfiguration.LivenessProviderType> getField28 = (global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.GlobalConfiguration.LivenessProviderType>)global::Orleans.Serialization.SerializationManager.@GetGetter(field28);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.GlobalConfiguration.LivenessProviderType> setField28 = (global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.GlobalConfiguration.LivenessProviderType>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field28);
        private static readonly global::System.Reflection.FieldInfo field31 = typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration).@GetField("reminderServiceType", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.GlobalConfiguration.ReminderServiceProviderType> getField31 = (global::System.Func<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.GlobalConfiguration.ReminderServiceProviderType>)global::Orleans.Serialization.SerializationManager.@GetGetter(field31);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.GlobalConfiguration.ReminderServiceProviderType> setField31 = (global::System.Action<global::Orleans.Runtime.Configuration.GlobalConfiguration, global::Orleans.Runtime.Configuration.GlobalConfiguration.ReminderServiceProviderType>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field31);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.Configuration.GlobalConfiguration input = ((global::Orleans.Runtime.Configuration.GlobalConfiguration)original);
            global::Orleans.Runtime.Configuration.GlobalConfiguration result = (global::Orleans.Runtime.Configuration.GlobalConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration));
            result.@ActivationCountBasedPlacementChooseOutOf = input.@ActivationCountBasedPlacementChooseOutOf;
            result.@AdoInvariant = input.@AdoInvariant;
            setField0(result, (global::Orleans.Runtime.Configuration.ApplicationConfiguration)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Application));
            result.@BufferPoolBufferSize = input.@BufferPoolBufferSize;
            result.@BufferPoolMaxSize = input.@BufferPoolMaxSize;
            result.@BufferPoolPreallocationSize = input.@BufferPoolPreallocationSize;
            result.@CacheSize = input.@CacheSize;
            result.@CacheTTLExtensionFactor = input.@CacheTTLExtensionFactor;
            result.@ClientRegistrationRefresh = input.@ClientRegistrationRefresh;
            result.@ClientSenderBuckets = input.@ClientSenderBuckets;
            setField19(result, getField19(input));
            result.@DataConnectionString = input.@DataConnectionString;
            result.@DeathVoteExpirationTimeout = input.@DeathVoteExpirationTimeout;
            result.@DefaultMultiClusterRegistrationStrategy = input.@DefaultMultiClusterRegistrationStrategy;
            result.@DefaultPlacementStrategy = input.@DefaultPlacementStrategy;
            result.@DeploymentId = input.@DeploymentId;
            result.@DeploymentLoadPublisherRefreshTime = input.@DeploymentLoadPublisherRefreshTime;
            result.@DirectoryCachingStrategy = input.@DirectoryCachingStrategy;
            result.@DirectoryLazyDeregistrationDelay = input.@DirectoryLazyDeregistrationDelay;
            result.@DropExpiredMessages = input.@DropExpiredMessages;
            setField9(result, (global::Orleans.Runtime.Configuration.ConfigValue<global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField9(input)));
            result.@GatewaySenderQueues = input.@GatewaySenderQueues;
            result.@IAmAliveTablePublishTimeout = input.@IAmAliveTablePublishTimeout;
            result.@InitialCacheTTL = input.@InitialCacheTTL;
            result.@LivenessEnabled = input.@LivenessEnabled;
            result.@MaxForwardCount = input.@MaxForwardCount;
            result.@MaxJoinAttemptTime = input.@MaxJoinAttemptTime;
            result.@MaxMessageBatchingSize = input.@MaxMessageBatchingSize;
            result.@MaxResendCount = input.@MaxResendCount;
            result.@MaxSocketAge = input.@MaxSocketAge;
            setField24(result, input.@MaxStorageBusyRetries);
            result.@MaximumCacheTTL = input.@MaximumCacheTTL;
            result.@MembershipTableAssembly = input.@MembershipTableAssembly;
            setField62(result, getField62(input));
            result.@MockReminderTableTimeout = input.@MockReminderTableTimeout;
            result.@NumMissedProbesLimit = input.@NumMissedProbesLimit;
            result.@NumMissedTableIAmAliveLimit = input.@NumMissedTableIAmAliveLimit;
            result.@NumProbedSilos = input.@NumProbedSilos;
            result.@NumVirtualBucketsConsistentRing = input.@NumVirtualBucketsConsistentRing;
            result.@NumVotesForDeathDeclaration = input.@NumVotesForDeathDeclaration;
            setField37(result, getField37(input));
            result.@ProbeTimeout = input.@ProbeTimeout;
            result.@ProviderConfigurations = (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@ProviderConfigurations);
            setField61(result, getField61(input));
            result.@ReminderTableAssembly = input.@ReminderTableAssembly;
            result.@ResendOnTimeout = input.@ResendOnTimeout;
            result.@ResponseTimeout = input.@ResponseTimeout;
            setField1(result, (global::System.Collections.Generic.IList<global::System.Net.IPEndPoint>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@SeedNodes));
            setField60(result, (global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@SerializationProviders));
            result.@ServiceId = (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@ServiceId);
            result.@SiloSenderQueues = input.@SiloSenderQueues;
            result.@Subnet = (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Subnet);
            result.@TableRefreshTimeout = input.@TableRefreshTimeout;
            result.@UseJsonFallbackSerializer = input.@UseJsonFallbackSerializer;
            result.@UseLivenessGossip = input.@UseLivenessGossip;
            result.@UseMessageBatching = input.@UseMessageBatching;
            result.@UseStandardSerializer = input.@UseStandardSerializer;
            result.@UseVirtualBucketsConsistentRing = input.@UseVirtualBucketsConsistentRing;
            setField33(result, getField33(input));
            setField43(result, getField43(input));
            setField42(result, getField42(input));
            setField63(result, getField63(input));
            setField28(result, getField28(input));
            setField31(result, getField31(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.GlobalConfiguration input = (global::Orleans.Runtime.Configuration.GlobalConfiguration)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ActivationCountBasedPlacementChooseOutOf, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@AdoInvariant, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Application, stream, typeof (global::Orleans.Runtime.Configuration.ApplicationConfiguration));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@BufferPoolBufferSize, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@BufferPoolMaxSize, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@BufferPoolPreallocationSize, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@CacheSize, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@CacheTTLExtensionFactor, stream, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ClientRegistrationRefresh, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ClientSenderBuckets, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField19(input), stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DataConnectionString, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DeathVoteExpirationTimeout, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DefaultMultiClusterRegistrationStrategy, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DefaultPlacementStrategy, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DeploymentId, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DeploymentLoadPublisherRefreshTime, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DirectoryCachingStrategy, stream, typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration.DirectoryCachingStrategyType));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DirectoryLazyDeregistrationDelay, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DropExpiredMessages, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField9(input), stream, typeof (global::Orleans.Runtime.Configuration.ConfigValue<global::System.Int32>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GatewaySenderQueues, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@IAmAliveTablePublishTimeout, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@InitialCacheTTL, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LivenessEnabled, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxForwardCount, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxJoinAttemptTime, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxMessageBatchingSize, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxResendCount, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxSocketAge, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxStorageBusyRetries, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaximumCacheTTL, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MembershipTableAssembly, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField62(input), stream, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MockReminderTableTimeout, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@NumMissedProbesLimit, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@NumMissedTableIAmAliveLimit, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@NumProbedSilos, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@NumVirtualBucketsConsistentRing, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@NumVotesForDeathDeclaration, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField37(input), stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ProbeTimeout, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ProviderConfigurations, stream, typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField61(input), stream, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ReminderTableAssembly, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ResendOnTimeout, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ResponseTimeout, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SeedNodes, stream, typeof (global::System.Collections.Generic.IList<global::System.Net.IPEndPoint>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SerializationProviders, stream, typeof (global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ServiceId, stream, typeof (global::System.Guid));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SiloSenderQueues, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Subnet, stream, typeof (global::System.Byte[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TableRefreshTimeout, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@UseJsonFallbackSerializer, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@UseLivenessGossip, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@UseMessageBatching, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@UseStandardSerializer, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@UseVirtualBucketsConsistentRing, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField33(input), stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField43(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField42(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField63(input), stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField28(input), stream, typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration.LivenessProviderType));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField31(input), stream, typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration.ReminderServiceProviderType));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.Configuration.GlobalConfiguration result = (global::Orleans.Runtime.Configuration.GlobalConfiguration)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@ActivationCountBasedPlacementChooseOutOf = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@AdoInvariant = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            setField0(result, (global::Orleans.Runtime.Configuration.ApplicationConfiguration)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.ApplicationConfiguration), stream));
            result.@BufferPoolBufferSize = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@BufferPoolMaxSize = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@BufferPoolPreallocationSize = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@CacheSize = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@CacheTTLExtensionFactor = (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), stream);
            result.@ClientRegistrationRefresh = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream);
            result.@ClientSenderBuckets = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            setField19(result, (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream));
            result.@DataConnectionString = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@DeathVoteExpirationTimeout = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream);
            result.@DefaultMultiClusterRegistrationStrategy = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@DefaultPlacementStrategy = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@DeploymentId = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@DeploymentLoadPublisherRefreshTime = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream);
            result.@DirectoryCachingStrategy = (global::Orleans.Runtime.Configuration.GlobalConfiguration.DirectoryCachingStrategyType)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration.DirectoryCachingStrategyType), stream);
            result.@DirectoryLazyDeregistrationDelay = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream);
            result.@DropExpiredMessages = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            setField9(result, (global::Orleans.Runtime.Configuration.ConfigValue<global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.ConfigValue<global::System.Int32>), stream));
            result.@GatewaySenderQueues = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@IAmAliveTablePublishTimeout = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream);
            result.@InitialCacheTTL = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream);
            result.@LivenessEnabled = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            result.@MaxForwardCount = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@MaxJoinAttemptTime = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream);
            result.@MaxMessageBatchingSize = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@MaxResendCount = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@MaxSocketAge = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream);
            setField24(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            result.@MaximumCacheTTL = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream);
            result.@MembershipTableAssembly = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            setField62(result, (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), stream));
            result.@MockReminderTableTimeout = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream);
            result.@NumMissedProbesLimit = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@NumMissedTableIAmAliveLimit = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@NumProbedSilos = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@NumVirtualBucketsConsistentRing = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@NumVotesForDeathDeclaration = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            setField37(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            result.@ProbeTimeout = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream);
            result.@ProviderConfigurations = (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.ProviderCategoryConfiguration>), stream);
            setField61(result, (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), stream));
            result.@ReminderTableAssembly = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@ResendOnTimeout = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            result.@ResponseTimeout = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream);
            setField1(result, (global::System.Collections.Generic.IList<global::System.Net.IPEndPoint>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IList<global::System.Net.IPEndPoint>), stream));
            setField60(result, (global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::System.Reflection.TypeInfo>), stream));
            result.@ServiceId = (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Guid), stream);
            result.@SiloSenderQueues = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@Subnet = (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte[]), stream);
            result.@TableRefreshTimeout = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream);
            result.@UseJsonFallbackSerializer = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            result.@UseLivenessGossip = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            result.@UseMessageBatching = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            result.@UseStandardSerializer = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            result.@UseVirtualBucketsConsistentRing = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            setField33(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            setField43(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField42(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField63(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            setField28(result, (global::Orleans.Runtime.Configuration.GlobalConfiguration.LivenessProviderType)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration.LivenessProviderType), stream));
            setField31(result, (global::Orleans.Runtime.Configuration.GlobalConfiguration.ReminderServiceProviderType)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration.ReminderServiceProviderType), stream));
            return (global::Orleans.Runtime.Configuration.GlobalConfiguration)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_Configuration_GlobalConfigurationSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.NodeConfiguration)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_NodeConfigurationSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.Configuration.NodeConfiguration).@GetField("<DNSHostName>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.String> setField2 = (global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field15 = typeof (global::Orleans.Runtime.Configuration.NodeConfiguration).@GetField("<InjectMoreWorkerThreads>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Boolean> getField15 = (global::System.Func<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field15);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Boolean> setField15 = (global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field15);
        private static readonly global::System.Reflection.FieldInfo field9 = typeof (global::Orleans.Runtime.Configuration.NodeConfiguration).@GetField("<IsPrimaryNode>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Boolean> setField9 = (global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field9);
        private static readonly global::System.Reflection.FieldInfo field10 = typeof (global::Orleans.Runtime.Configuration.NodeConfiguration).@GetField("<IsSeedNode>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Boolean> setField10 = (global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field10);
        private static readonly global::System.Reflection.FieldInfo field18 = typeof (global::Orleans.Runtime.Configuration.NodeConfiguration).@GetField("<LimitManager>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::Orleans.Runtime.Configuration.LimitManager> setField18 = (global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::Orleans.Runtime.Configuration.LimitManager>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field18);
        private static readonly global::System.Reflection.FieldInfo field8 = typeof (global::Orleans.Runtime.Configuration.NodeConfiguration).@GetField("<Subnet>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Byte[]> getField8 = (global::System.Func<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Byte[]>)global::Orleans.Serialization.SerializationManager.@GetGetter(field8);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Byte[]> setField8 = (global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Byte[]>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field8);
        private static readonly global::System.Reflection.FieldInfo field21 = typeof (global::Orleans.Runtime.Configuration.NodeConfiguration).@GetField("<TraceLevelOverrides>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Collections.Generic.IList<global::System.Tuple<global::System.String, global::Orleans.Runtime.Severity>>> setField21 = (global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.Collections.Generic.IList<global::System.Tuple<global::System.String, global::Orleans.Runtime.Severity>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field21);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.Configuration.NodeConfiguration).@GetField("creationTimestamp", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.DateTime> getField0 = (global::System.Func<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.DateTime> setField0 = (global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.Configuration.NodeConfiguration).@GetField("siloName", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.String> getField1 = (global::System.Func<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.String> setField1 = (global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field19 = typeof (global::Orleans.Runtime.Configuration.NodeConfiguration).@GetField("traceFilePattern", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.String> getField19 = (global::System.Func<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field19);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.String> setField19 = (global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field19);
        private static readonly global::System.Reflection.FieldInfo field34 = typeof (global::Orleans.Runtime.Configuration.NodeConfiguration).@GetField("workingStoreDir", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.String> getField34 = (global::System.Func<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field34);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.String> setField34 = (global::System.Action<global::Orleans.Runtime.Configuration.NodeConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field34);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.Configuration.NodeConfiguration input = ((global::Orleans.Runtime.Configuration.NodeConfiguration)original);
            global::Orleans.Runtime.Configuration.NodeConfiguration result = new global::Orleans.Runtime.Configuration.NodeConfiguration();
            result.@ActivationSchedulingQuantum = input.@ActivationSchedulingQuantum;
            result.@AddressType = input.@AddressType;
            result.@BulkMessageLimit = input.@BulkMessageLimit;
            setField2(result, input.@DNSHostName);
            result.@DefaultConnectionLimit = input.@DefaultConnectionLimit;
            result.@DefaultTraceLevel = input.@DefaultTraceLevel;
            result.@DelayWarningThreshold = input.@DelayWarningThreshold;
            result.@Expect100Continue = input.@Expect100Continue;
            result.@Generation = input.@Generation;
            result.@HostNameOrIPAddress = input.@HostNameOrIPAddress;
            setField15(result, getField15(input));
            setField9(result, input.@IsPrimaryNode);
            setField10(result, input.@IsSeedNode);
            result.@LargeMessageWarningThreshold = input.@LargeMessageWarningThreshold;
            setField18(result, (global::Orleans.Runtime.Configuration.LimitManager)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@LimitManager));
            result.@LoadSheddingEnabled = input.@LoadSheddingEnabled;
            result.@LoadSheddingLimit = input.@LoadSheddingLimit;
            result.@MaxActiveThreads = input.@MaxActiveThreads;
            result.@MinDotNetThreadPoolSize = input.@MinDotNetThreadPoolSize;
            result.@Port = input.@Port;
            result.@PropagateActivityId = input.@PropagateActivityId;
            result.@ProxyGatewayEndpoint = (global::System.Net.IPEndPoint)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@ProxyGatewayEndpoint);
            result.@SiloShutdownEventName = input.@SiloShutdownEventName;
            result.@StartupTypeName = input.@StartupTypeName;
            result.@StatisticsCollectionLevel = input.@StatisticsCollectionLevel;
            result.@StatisticsLogWriteInterval = input.@StatisticsLogWriteInterval;
            result.@StatisticsMetricsTableWriteInterval = input.@StatisticsMetricsTableWriteInterval;
            result.@StatisticsPerfCountersWriteInterval = input.@StatisticsPerfCountersWriteInterval;
            result.@StatisticsProviderName = input.@StatisticsProviderName;
            result.@StatisticsWriteLogStatisticsToTable = input.@StatisticsWriteLogStatisticsToTable;
            setField8(result, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField8(input)));
            result.@TraceFileName = input.@TraceFileName;
            setField21(result, (global::System.Collections.Generic.IList<global::System.Tuple<global::System.String, global::Orleans.Runtime.Severity>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@TraceLevelOverrides));
            result.@TraceToConsole = input.@TraceToConsole;
            result.@TurnWarningLengthThreshold = input.@TurnWarningLengthThreshold;
            result.@UseNagleAlgorithm = input.@UseNagleAlgorithm;
            setField0(result, getField0(input));
            setField1(result, getField1(input));
            setField19(result, getField19(input));
            setField34(result, getField34(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.NodeConfiguration input = (global::Orleans.Runtime.Configuration.NodeConfiguration)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ActivationSchedulingQuantum, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@AddressType, stream, typeof (global::System.Net.Sockets.AddressFamily));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@BulkMessageLimit, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DNSHostName, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DefaultConnectionLimit, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DefaultTraceLevel, stream, typeof (global::Orleans.Runtime.Severity));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DelayWarningThreshold, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Expect100Continue, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Generation, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@HostNameOrIPAddress, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField15(input), stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@IsPrimaryNode, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@IsSeedNode, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LargeMessageWarningThreshold, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LimitManager, stream, typeof (global::Orleans.Runtime.Configuration.LimitManager));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LoadSheddingEnabled, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LoadSheddingLimit, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MaxActiveThreads, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MinDotNetThreadPoolSize, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Port, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@PropagateActivityId, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ProxyGatewayEndpoint, stream, typeof (global::System.Net.IPEndPoint));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SiloShutdownEventName, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StartupTypeName, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StatisticsCollectionLevel, stream, typeof (global::Orleans.Runtime.Configuration.StatisticsLevel));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StatisticsLogWriteInterval, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StatisticsMetricsTableWriteInterval, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StatisticsPerfCountersWriteInterval, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StatisticsProviderName, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StatisticsWriteLogStatisticsToTable, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField8(input), stream, typeof (global::System.Byte[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TraceFileName, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TraceLevelOverrides, stream, typeof (global::System.Collections.Generic.IList<global::System.Tuple<global::System.String, global::Orleans.Runtime.Severity>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TraceToConsole, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TurnWarningLengthThreshold, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@UseNagleAlgorithm, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField19(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField34(input), stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.Configuration.NodeConfiguration result = new global::Orleans.Runtime.Configuration.NodeConfiguration();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@ActivationSchedulingQuantum = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream);
            result.@AddressType = (global::System.Net.Sockets.AddressFamily)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Net.Sockets.AddressFamily), stream);
            result.@BulkMessageLimit = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            setField2(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            result.@DefaultConnectionLimit = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@DefaultTraceLevel = (global::Orleans.Runtime.Severity)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Severity), stream);
            result.@DelayWarningThreshold = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream);
            result.@Expect100Continue = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            result.@Generation = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@HostNameOrIPAddress = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            setField15(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            setField9(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            setField10(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            result.@LargeMessageWarningThreshold = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            setField18(result, (global::Orleans.Runtime.Configuration.LimitManager)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.LimitManager), stream));
            result.@LoadSheddingEnabled = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            result.@LoadSheddingLimit = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@MaxActiveThreads = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@MinDotNetThreadPoolSize = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@Port = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@PropagateActivityId = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            result.@ProxyGatewayEndpoint = (global::System.Net.IPEndPoint)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Net.IPEndPoint), stream);
            result.@SiloShutdownEventName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@StartupTypeName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@StatisticsCollectionLevel = (global::Orleans.Runtime.Configuration.StatisticsLevel)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.StatisticsLevel), stream);
            result.@StatisticsLogWriteInterval = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream);
            result.@StatisticsMetricsTableWriteInterval = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream);
            result.@StatisticsPerfCountersWriteInterval = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream);
            result.@StatisticsProviderName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@StatisticsWriteLogStatisticsToTable = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            setField8(result, (global::System.Byte[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Byte[]), stream));
            result.@TraceFileName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            setField21(result, (global::System.Collections.Generic.IList<global::System.Tuple<global::System.String, global::Orleans.Runtime.Severity>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IList<global::System.Tuple<global::System.String, global::Orleans.Runtime.Severity>>), stream));
            result.@TraceToConsole = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            result.@TurnWarningLengthThreshold = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream);
            result.@UseNagleAlgorithm = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            setField0(result, (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), stream));
            setField1(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField19(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField34(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            return (global::Orleans.Runtime.Configuration.NodeConfiguration)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.Configuration.NodeConfiguration), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_Configuration_NodeConfigurationSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.Configuration.ClusterConfiguration)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_Configuration_ClusterConfigurationSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.Configuration.ClusterConfiguration).@GetField("<Defaults>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::Orleans.Runtime.Configuration.NodeConfiguration> setField1 = (global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::Orleans.Runtime.Configuration.NodeConfiguration>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.Configuration.ClusterConfiguration).@GetField("<Globals>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::Orleans.Runtime.Configuration.GlobalConfiguration> setField0 = (global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::Orleans.Runtime.Configuration.GlobalConfiguration>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::Orleans.Runtime.Configuration.ClusterConfiguration).@GetField("<IsRunningAsUnitTest>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Boolean> getField7 = (global::System.Func<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field7);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Boolean> setField7 = (global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field7);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Runtime.Configuration.ClusterConfiguration).@GetField("<Overrides>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.NodeConfiguration>> setField4 = (global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.NodeConfiguration>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.Configuration.ClusterConfiguration).@GetField("<SourceFile>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.String> setField2 = (global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Orleans.Runtime.Configuration.ClusterConfiguration).@GetField("listeners", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.List<global::System.Action>>> getField6 = (global::System.Func<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.List<global::System.Action>>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field6);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.List<global::System.Action>>> setField6 = (global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.List<global::System.Action>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field6);
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Orleans.Runtime.Configuration.ClusterConfiguration).@GetField("overrideXml", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>> getField5 = (global::System.Func<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field5);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>> setField5 = (global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Runtime.Configuration.ClusterConfiguration).@GetField("primaryNode", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Net.IPEndPoint> getField3 = (global::System.Func<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Net.IPEndPoint>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Net.IPEndPoint> setField3 = (global::System.Action<global::Orleans.Runtime.Configuration.ClusterConfiguration, global::System.Net.IPEndPoint>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.Configuration.ClusterConfiguration input = ((global::Orleans.Runtime.Configuration.ClusterConfiguration)original);
            global::Orleans.Runtime.Configuration.ClusterConfiguration result = new global::Orleans.Runtime.Configuration.ClusterConfiguration();
            setField1(result, (global::Orleans.Runtime.Configuration.NodeConfiguration)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Defaults));
            setField0(result, (global::Orleans.Runtime.Configuration.GlobalConfiguration)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Globals));
            setField7(result, getField7(input));
            setField4(result, (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.NodeConfiguration>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Overrides));
            setField2(result, input.@SourceFile);
            setField6(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.List<global::System.Action>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField6(input)));
            setField5(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField5(input)));
            setField3(result, (global::System.Net.IPEndPoint)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField3(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.Configuration.ClusterConfiguration input = (global::Orleans.Runtime.Configuration.ClusterConfiguration)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Defaults, stream, typeof (global::Orleans.Runtime.Configuration.NodeConfiguration));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Globals, stream, typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField7(input), stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Overrides, stream, typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.NodeConfiguration>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SourceFile, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField6(input), stream, typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.List<global::System.Action>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField5(input), stream, typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), stream, typeof (global::System.Net.IPEndPoint));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.Configuration.ClusterConfiguration result = new global::Orleans.Runtime.Configuration.ClusterConfiguration();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::Orleans.Runtime.Configuration.NodeConfiguration)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.NodeConfiguration), stream));
            setField0(result, (global::Orleans.Runtime.Configuration.GlobalConfiguration)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Configuration.GlobalConfiguration), stream));
            setField7(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            setField4(result, (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.NodeConfiguration>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IDictionary<global::System.String, global::Orleans.Runtime.Configuration.NodeConfiguration>), stream));
            setField2(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField6(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.List<global::System.Action>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.List<global::System.Action>>), stream));
            setField5(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>), stream));
            setField3(result, (global::System.Net.IPEndPoint)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Net.IPEndPoint), stream));
            return (global::Orleans.Runtime.Configuration.ClusterConfiguration)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.Configuration.ClusterConfiguration), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_Configuration_ClusterConfigurationSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.IMembershipTableGrain))]
    internal class OrleansCodeGenMembershipTableGrainReference : global::Orleans.Runtime.GrainReference, global::Orleans.IMembershipTableGrain
    {
        protected @OrleansCodeGenMembershipTableGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenMembershipTableGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -1256503757;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.IMembershipTableGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -1256503757;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -1256503757:
                    switch (@methodId)
                    {
                        case -1745428353:
                            return "InitializeMembershipTable";
                        case 106897969:
                            return "DeleteMembershipTableEntries";
                        case -1440482971:
                            return "ReadRow";
                        case 572429157:
                            return "ReadAll";
                        case -1925884676:
                            return "InsertRow";
                        case 1964092804:
                            return "UpdateRow";
                        case -1315256828:
                            return "UpdateIAmAlive";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1256503757 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @InitializeMembershipTable(global::Orleans.Runtime.Configuration.GlobalConfiguration @globalConfiguration, global::System.Boolean @tryInitTableVersion, global::Orleans.Runtime.TraceLogger @traceLogger)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1745428353, new global::System.Object[]{@globalConfiguration, @tryInitTableVersion, @traceLogger});
        }

        public global::System.Threading.Tasks.Task @DeleteMembershipTableEntries(global::System.String @deploymentId)
        {
            return base.@InvokeMethodAsync<global::System.Object>(106897969, new global::System.Object[]{@deploymentId});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.MembershipTableData> @ReadRow(global::Orleans.Runtime.SiloAddress @key)
        {
            return base.@InvokeMethodAsync<global::Orleans.MembershipTableData>(-1440482971, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.MembershipTableData> @ReadAll()
        {
            return base.@InvokeMethodAsync<global::Orleans.MembershipTableData>(572429157, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @InsertRow(global::Orleans.MembershipEntry @entry, global::Orleans.TableVersion @tableVersion)
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-1925884676, new global::System.Object[]{@entry, @tableVersion});
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @UpdateRow(global::Orleans.MembershipEntry @entry, global::System.String @etag, global::Orleans.TableVersion @tableVersion)
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1964092804, new global::System.Object[]{@entry, @etag, @tableVersion});
        }

        public global::System.Threading.Tasks.Task @UpdateIAmAlive(global::Orleans.MembershipEntry @entry)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1315256828, new global::System.Object[]{@entry});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Orleans.IMembershipTableGrain", -1256503757, typeof (global::Orleans.IMembershipTableGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenMembershipTableGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -1256503757:
                        switch (methodId)
                        {
                            case -1745428353:
                                return ((global::Orleans.IMembershipTableGrain)@grain).@InitializeMembershipTable((global::Orleans.Runtime.Configuration.GlobalConfiguration)arguments[0], (global::System.Boolean)arguments[1], (global::Orleans.Runtime.TraceLogger)arguments[2]).@Box();
                            case 106897969:
                                return ((global::Orleans.IMembershipTableGrain)@grain).@DeleteMembershipTableEntries((global::System.String)arguments[0]).@Box();
                            case -1440482971:
                                return ((global::Orleans.IMembershipTableGrain)@grain).@ReadRow((global::Orleans.Runtime.SiloAddress)arguments[0]).@Box();
                            case 572429157:
                                return ((global::Orleans.IMembershipTableGrain)@grain).@ReadAll().@Box();
                            case -1925884676:
                                return ((global::Orleans.IMembershipTableGrain)@grain).@InsertRow((global::Orleans.MembershipEntry)arguments[0], (global::Orleans.TableVersion)arguments[1]).@Box();
                            case 1964092804:
                                return ((global::Orleans.IMembershipTableGrain)@grain).@UpdateRow((global::Orleans.MembershipEntry)arguments[0], (global::System.String)arguments[1], (global::Orleans.TableVersion)arguments[2]).@Box();
                            case -1315256828:
                                return ((global::Orleans.IMembershipTableGrain)@grain).@UpdateIAmAlive((global::Orleans.MembershipEntry)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1256503757 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -1256503757;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.TraceLogger)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_TraceLoggerSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.TraceLogger).@GetField("defaultCopiedCounter", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.TraceLogger, global::System.Int32> getField0 = (global::System.Func<global::Orleans.Runtime.TraceLogger, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.TraceLogger, global::System.Int32> setField0 = (global::System.Action<global::Orleans.Runtime.TraceLogger, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::Orleans.Runtime.TraceLogger).@GetField("flushInterval", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.TraceLogger, global::System.TimeSpan> getField7 = (global::System.Func<global::Orleans.Runtime.TraceLogger, global::System.TimeSpan>)global::Orleans.Serialization.SerializationManager.@GetGetter(field7);
        private static readonly global::System.Action<global::Orleans.Runtime.TraceLogger, global::System.TimeSpan> setField7 = (global::System.Action<global::Orleans.Runtime.TraceLogger, global::System.TimeSpan>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field7);
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Orleans.Runtime.TraceLogger).@GetField("lastBulkLogMessageFlush", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.TraceLogger, global::System.DateTime> getField6 = (global::System.Func<global::Orleans.Runtime.TraceLogger, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetGetter(field6);
        private static readonly global::System.Action<global::Orleans.Runtime.TraceLogger, global::System.DateTime> setField6 = (global::System.Action<global::Orleans.Runtime.TraceLogger, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field6);
        private static readonly global::System.Reflection.FieldInfo field8 = typeof (global::Orleans.Runtime.TraceLogger).@GetField("lastFlush", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.TraceLogger, global::System.DateTime> getField8 = (global::System.Func<global::Orleans.Runtime.TraceLogger, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetGetter(field8);
        private static readonly global::System.Action<global::Orleans.Runtime.TraceLogger, global::System.DateTime> setField8 = (global::System.Action<global::Orleans.Runtime.TraceLogger, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field8);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Runtime.TraceLogger).@GetField("logName", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.TraceLogger, global::System.String> getField4 = (global::System.Func<global::Orleans.Runtime.TraceLogger, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Orleans.Runtime.TraceLogger, global::System.String> setField4 = (global::System.Action<global::Orleans.Runtime.TraceLogger, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Runtime.TraceLogger).@GetField("loggerType", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.TraceLogger, global::Orleans.Runtime.TraceLogger.LoggerType> getField3 = (global::System.Func<global::Orleans.Runtime.TraceLogger, global::Orleans.Runtime.TraceLogger.LoggerType>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Orleans.Runtime.TraceLogger, global::Orleans.Runtime.TraceLogger.LoggerType> setField3 = (global::System.Action<global::Orleans.Runtime.TraceLogger, global::Orleans.Runtime.TraceLogger.LoggerType>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Orleans.Runtime.TraceLogger).@GetField("recentLogMessageCounts", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.TraceLogger, global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.Int32>> getField5 = (global::System.Func<global::Orleans.Runtime.TraceLogger, global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.Int32>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field5);
        private static readonly global::System.Action<global::Orleans.Runtime.TraceLogger, global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.Int32>> setField5 = (global::System.Action<global::Orleans.Runtime.TraceLogger, global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.Int32>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.TraceLogger).@GetField("severity", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.TraceLogger, global::Orleans.Runtime.Severity> getField1 = (global::System.Func<global::Orleans.Runtime.TraceLogger, global::Orleans.Runtime.Severity>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.TraceLogger, global::Orleans.Runtime.Severity> setField1 = (global::System.Action<global::Orleans.Runtime.TraceLogger, global::Orleans.Runtime.Severity>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.TraceLogger).@GetField("useCustomSeverityLevel", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.TraceLogger, global::System.Boolean> getField2 = (global::System.Func<global::Orleans.Runtime.TraceLogger, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Runtime.TraceLogger, global::System.Boolean> setField2 = (global::System.Action<global::Orleans.Runtime.TraceLogger, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.TraceLogger input = ((global::Orleans.Runtime.TraceLogger)original);
            global::Orleans.Runtime.TraceLogger result = (global::Orleans.Runtime.TraceLogger)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.TraceLogger));
            setField0(result, getField0(input));
            setField7(result, getField7(input));
            setField6(result, getField6(input));
            setField8(result, getField8(input));
            setField4(result, getField4(input));
            setField3(result, getField3(input));
            setField5(result, (global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField5(input)));
            setField1(result, getField1(input));
            setField2(result, getField2(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.TraceLogger input = (global::Orleans.Runtime.TraceLogger)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField7(input), stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField6(input), stream, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField8(input), stream, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), stream, typeof (global::Orleans.Runtime.TraceLogger.LoggerType));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField5(input), stream, typeof (global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.Int32>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::Orleans.Runtime.Severity));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (global::System.Boolean));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.TraceLogger result = (global::Orleans.Runtime.TraceLogger)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Orleans.Runtime.TraceLogger));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField7(result, (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream));
            setField6(result, (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), stream));
            setField8(result, (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), stream));
            setField4(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField3(result, (global::Orleans.Runtime.TraceLogger.LoggerType)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.TraceLogger.LoggerType), stream));
            setField5(result, (global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.Int32>), stream));
            setField1(result, (global::Orleans.Runtime.Severity)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Severity), stream));
            setField2(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            return (global::Orleans.Runtime.TraceLogger)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.TraceLogger), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_TraceLoggerSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.IReminderTableGrain))]
    internal class OrleansCodeGenReminderTableGrainReference : global::Orleans.Runtime.GrainReference, global::Orleans.IReminderTableGrain
    {
        protected @OrleansCodeGenReminderTableGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenReminderTableGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -1135060418;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.IReminderTableGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -1135060418;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -1135060418:
                    switch (@methodId)
                    {
                        case 187953678:
                            return "Init";
                        case -355259193:
                            return "ReadRows";
                        case -497403264:
                            return "ReadRows";
                        case 1312340311:
                            return "ReadRow";
                        case -1664645999:
                            return "UpsertRow";
                        case -1912556377:
                            return "RemoveRow";
                        case 120951690:
                            return "TestOnlyClearTable";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1135060418 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @Init(global::Orleans.Runtime.Configuration.GlobalConfiguration @config, global::Orleans.Runtime.TraceLogger @traceLogger)
        {
            return base.@InvokeMethodAsync<global::System.Object>(187953678, new global::System.Object[]{@config, @traceLogger});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.ReminderTableData> @ReadRows(global::Orleans.Runtime.GrainReference @key)
        {
            return base.@InvokeMethodAsync<global::Orleans.ReminderTableData>(-355259193, new global::System.Object[]{@key});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.ReminderTableData> @ReadRows(global::System.UInt32 @begin, global::System.UInt32 @end)
        {
            return base.@InvokeMethodAsync<global::Orleans.ReminderTableData>(-497403264, new global::System.Object[]{@begin, @end});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.ReminderEntry> @ReadRow(global::Orleans.Runtime.GrainReference @grainRef, global::System.String @reminderName)
        {
            return base.@InvokeMethodAsync<global::Orleans.ReminderEntry>(1312340311, new global::System.Object[]{@grainRef, @reminderName});
        }

        public global::System.Threading.Tasks.Task<global::System.String> @UpsertRow(global::Orleans.ReminderEntry @entry)
        {
            return base.@InvokeMethodAsync<global::System.String>(-1664645999, new global::System.Object[]{@entry});
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @RemoveRow(global::Orleans.Runtime.GrainReference @grainRef, global::System.String @reminderName, global::System.String @eTag)
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(-1912556377, new global::System.Object[]{@grainRef, @reminderName, @eTag});
        }

        public global::System.Threading.Tasks.Task @TestOnlyClearTable()
        {
            return base.@InvokeMethodAsync<global::System.Object>(120951690, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Orleans.IReminderTableGrain", -1135060418, typeof (global::Orleans.IReminderTableGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenReminderTableGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -1135060418:
                        switch (methodId)
                        {
                            case 187953678:
                                return ((global::Orleans.IReminderTableGrain)@grain).@Init((global::Orleans.Runtime.Configuration.GlobalConfiguration)arguments[0], (global::Orleans.Runtime.TraceLogger)arguments[1]).@Box();
                            case -355259193:
                                return ((global::Orleans.IReminderTableGrain)@grain).@ReadRows((global::Orleans.Runtime.GrainReference)arguments[0]).@Box();
                            case -497403264:
                                return ((global::Orleans.IReminderTableGrain)@grain).@ReadRows((global::System.UInt32)arguments[0], (global::System.UInt32)arguments[1]).@Box();
                            case 1312340311:
                                return ((global::Orleans.IReminderTableGrain)@grain).@ReadRow((global::Orleans.Runtime.GrainReference)arguments[0], (global::System.String)arguments[1]).@Box();
                            case -1664645999:
                                return ((global::Orleans.IReminderTableGrain)@grain).@UpsertRow((global::Orleans.ReminderEntry)arguments[0]).@Box();
                            case -1912556377:
                                return ((global::Orleans.IReminderTableGrain)@grain).@RemoveRow((global::Orleans.Runtime.GrainReference)arguments[0], (global::System.String)arguments[1], (global::System.String)arguments[2]).@Box();
                            case 120951690:
                                return ((global::Orleans.IReminderTableGrain)@grain).@TestOnlyClearTable().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1135060418 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -1135060418;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.ReminderTableData)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_ReminderTableDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.ReminderTableData).@GetField("<Reminders>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.ReminderTableData, global::System.Collections.Generic.IList<global::Orleans.ReminderEntry>> setField0 = (global::System.Action<global::Orleans.ReminderTableData, global::System.Collections.Generic.IList<global::Orleans.ReminderEntry>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.ReminderTableData input = ((global::Orleans.ReminderTableData)original);
            global::Orleans.ReminderTableData result = new global::Orleans.ReminderTableData();
            setField0(result, (global::System.Collections.Generic.IList<global::Orleans.ReminderEntry>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Reminders));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.ReminderTableData input = (global::Orleans.ReminderTableData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Reminders, stream, typeof (global::System.Collections.Generic.IList<global::Orleans.ReminderEntry>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.ReminderTableData result = new global::Orleans.ReminderTableData();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Collections.Generic.IList<global::Orleans.ReminderEntry>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IList<global::Orleans.ReminderEntry>), stream));
            return (global::Orleans.ReminderTableData)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.ReminderTableData), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_ReminderTableDataSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.IReminderService))]
    internal class OrleansCodeGenReminderServiceReference : global::Orleans.Runtime.GrainReference, global::Orleans.IReminderService
    {
        protected @OrleansCodeGenReminderServiceReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenReminderServiceReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1450843817;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.IReminderService";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1450843817;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1450843817:
                    switch (@methodId)
                    {
                        case 1420312199:
                            return "Start";
                        case -1505116304:
                            return "Stop";
                        case 1588772828:
                            return "RegisterOrUpdateReminder";
                        case 622645164:
                            return "UnregisterReminder";
                        case 2144663751:
                            return "GetReminder";
                        case -1913437315:
                            return "GetReminders";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1450843817 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @Start()
        {
            return base.@InvokeMethodAsync<global::System.Object>(1420312199, null);
        }

        public global::System.Threading.Tasks.Task @Stop()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1505116304, null);
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Runtime.IGrainReminder> @RegisterOrUpdateReminder(global::Orleans.Runtime.GrainReference @grainRef, global::System.String @reminderName, global::System.TimeSpan @dueTime, global::System.TimeSpan @period)
        {
            return base.@InvokeMethodAsync<global::Orleans.Runtime.IGrainReminder>(1588772828, new global::System.Object[]{@grainRef, @reminderName, @dueTime, @period});
        }

        public global::System.Threading.Tasks.Task @UnregisterReminder(global::Orleans.Runtime.IGrainReminder @reminder)
        {
            return base.@InvokeMethodAsync<global::System.Object>(622645164, new global::System.Object[]{@reminder});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Runtime.IGrainReminder> @GetReminder(global::Orleans.Runtime.GrainReference @grainRef, global::System.String @reminderName)
        {
            return base.@InvokeMethodAsync<global::Orleans.Runtime.IGrainReminder>(2144663751, new global::System.Object[]{@grainRef, @reminderName});
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::Orleans.Runtime.IGrainReminder>> @GetReminders(global::Orleans.Runtime.GrainReference @grainRef)
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.List<global::Orleans.Runtime.IGrainReminder>>(-1913437315, new global::System.Object[]{@grainRef});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Orleans.IReminderService", 1450843817, typeof (global::Orleans.IReminderService)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenReminderServiceMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 1450843817:
                        switch (methodId)
                        {
                            case 1420312199:
                                return ((global::Orleans.IReminderService)@grain).@Start().@Box();
                            case -1505116304:
                                return ((global::Orleans.IReminderService)@grain).@Stop().@Box();
                            case 1588772828:
                                return ((global::Orleans.IReminderService)@grain).@RegisterOrUpdateReminder((global::Orleans.Runtime.GrainReference)arguments[0], (global::System.String)arguments[1], (global::System.TimeSpan)arguments[2], (global::System.TimeSpan)arguments[3]).@Box();
                            case 622645164:
                                return ((global::Orleans.IReminderService)@grain).@UnregisterReminder((global::Orleans.Runtime.IGrainReminder)arguments[0]).@Box();
                            case 2144663751:
                                return ((global::Orleans.IReminderService)@grain).@GetReminder((global::Orleans.Runtime.GrainReference)arguments[0], (global::System.String)arguments[1]).@Box();
                            case -1913437315:
                                return ((global::Orleans.IReminderService)@grain).@GetReminders((global::Orleans.Runtime.GrainReference)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1450843817 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1450843817;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.ISiloControl))]
    internal class OrleansCodeGenSiloControlReference : global::Orleans.Runtime.GrainReference, global::Orleans.ISiloControl
    {
        protected @OrleansCodeGenSiloControlReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenSiloControlReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -48122956;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.ISiloControl";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -48122956;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -48122956:
                    switch (@methodId)
                    {
                        case 1328855378:
                            return "Ping";
                        case -1376618190:
                            return "SetSystemLogLevel";
                        case -1564002097:
                            return "SetAppLogLevel";
                        case 1478092477:
                            return "SetLogLevel";
                        case 1478133812:
                            return "ForceGarbageCollection";
                        case -2082132213:
                            return "ForceActivationCollection";
                        case 20725113:
                            return "ForceRuntimeStatisticsCollection";
                        case 1041905033:
                            return "GetRuntimeStatistics";
                        case 174208232:
                            return "GetGrainStatistics";
                        case -1434082603:
                            return "GetSimpleGrainStatistics";
                        case 903115134:
                            return "GetDetailedGrainReport";
                        case 1634125253:
                            return "UpdateConfiguration";
                        case -1522955713:
                            return "GetActivationCount";
                        case -1426691790:
                            return "SendControlCommandToProvider";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -48122956 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @Ping(global::System.String @message)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1328855378, new global::System.Object[]{@message});
        }

        public global::System.Threading.Tasks.Task @SetSystemLogLevel(global::System.Int32 @traceLevel)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1376618190, new global::System.Object[]{@traceLevel});
        }

        public global::System.Threading.Tasks.Task @SetAppLogLevel(global::System.Int32 @traceLevel)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1564002097, new global::System.Object[]{@traceLevel});
        }

        public global::System.Threading.Tasks.Task @SetLogLevel(global::System.String @logName, global::System.Int32 @traceLevel)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1478092477, new global::System.Object[]{@logName, @traceLevel});
        }

        public global::System.Threading.Tasks.Task @ForceGarbageCollection()
        {
            return base.@InvokeMethodAsync<global::System.Object>(1478133812, null);
        }

        public global::System.Threading.Tasks.Task @ForceActivationCollection(global::System.TimeSpan @ageLimit)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-2082132213, new global::System.Object[]{@ageLimit});
        }

        public global::System.Threading.Tasks.Task @ForceRuntimeStatisticsCollection()
        {
            return base.@InvokeMethodAsync<global::System.Object>(20725113, null);
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Runtime.SiloRuntimeStatistics> @GetRuntimeStatistics()
        {
            return base.@InvokeMethodAsync<global::Orleans.Runtime.SiloRuntimeStatistics>(1041905033, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.GrainId, global::System.String, global::System.Int32>>> @GetGrainStatistics()
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.GrainId, global::System.String, global::System.Int32>>>(174208232, null);
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Runtime.SimpleGrainStatistic[]> @GetSimpleGrainStatistics()
        {
            return base.@InvokeMethodAsync<global::Orleans.Runtime.SimpleGrainStatistic[]>(-1434082603, null);
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Runtime.DetailedGrainReport> @GetDetailedGrainReport(global::Orleans.Runtime.GrainId @grainId)
        {
            return base.@InvokeMethodAsync<global::Orleans.Runtime.DetailedGrainReport>(903115134, new global::System.Object[]{@grainId});
        }

        public global::System.Threading.Tasks.Task @UpdateConfiguration(global::System.String @configuration)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1634125253, new global::System.Object[]{@configuration});
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @GetActivationCount()
        {
            return base.@InvokeMethodAsync<global::System.Int32>(-1522955713, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Object> @SendControlCommandToProvider(global::System.String @providerTypeFullName, global::System.String @providerName, global::System.Int32 @command, global::System.Object @arg)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1426691790, new global::System.Object[]{@providerTypeFullName, @providerName, @command, @arg});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Orleans.ISiloControl", -48122956, typeof (global::Orleans.ISiloControl)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenSiloControlMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -48122956:
                        switch (methodId)
                        {
                            case 1328855378:
                                return ((global::Orleans.ISiloControl)@grain).@Ping((global::System.String)arguments[0]).@Box();
                            case -1376618190:
                                return ((global::Orleans.ISiloControl)@grain).@SetSystemLogLevel((global::System.Int32)arguments[0]).@Box();
                            case -1564002097:
                                return ((global::Orleans.ISiloControl)@grain).@SetAppLogLevel((global::System.Int32)arguments[0]).@Box();
                            case 1478092477:
                                return ((global::Orleans.ISiloControl)@grain).@SetLogLevel((global::System.String)arguments[0], (global::System.Int32)arguments[1]).@Box();
                            case 1478133812:
                                return ((global::Orleans.ISiloControl)@grain).@ForceGarbageCollection().@Box();
                            case -2082132213:
                                return ((global::Orleans.ISiloControl)@grain).@ForceActivationCollection((global::System.TimeSpan)arguments[0]).@Box();
                            case 20725113:
                                return ((global::Orleans.ISiloControl)@grain).@ForceRuntimeStatisticsCollection().@Box();
                            case 1041905033:
                                return ((global::Orleans.ISiloControl)@grain).@GetRuntimeStatistics().@Box();
                            case 174208232:
                                return ((global::Orleans.ISiloControl)@grain).@GetGrainStatistics().@Box();
                            case -1434082603:
                                return ((global::Orleans.ISiloControl)@grain).@GetSimpleGrainStatistics().@Box();
                            case 903115134:
                                return ((global::Orleans.ISiloControl)@grain).@GetDetailedGrainReport((global::Orleans.Runtime.GrainId)arguments[0]).@Box();
                            case 1634125253:
                                return ((global::Orleans.ISiloControl)@grain).@UpdateConfiguration((global::System.String)arguments[0]).@Box();
                            case -1522955713:
                                return ((global::Orleans.ISiloControl)@grain).@GetActivationCount().@Box();
                            case -1426691790:
                                return ((global::Orleans.ISiloControl)@grain).@SendControlCommandToProvider((global::System.String)arguments[0], (global::System.String)arguments[1], (global::System.Int32)arguments[2], (global::System.Object)arguments[3]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -48122956 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -48122956;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.IRemindable))]
    internal class OrleansCodeGenRemindableReference : global::Orleans.Runtime.GrainReference, global::Orleans.IRemindable
    {
        protected @OrleansCodeGenRemindableReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenRemindableReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -831689659;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.IRemindable";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -831689659;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -831689659:
                    switch (@methodId)
                    {
                        case -1573596583:
                            return "ReceiveReminder";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -831689659 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @ReceiveReminder(global::System.String @reminderName, global::Orleans.Runtime.TickStatus @status)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1573596583, new global::System.Object[]{@reminderName, @status});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Orleans.IRemindable", -831689659, typeof (global::Orleans.IRemindable)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenRemindableMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -831689659:
                        switch (methodId)
                        {
                            case -1573596583:
                                return ((global::Orleans.IRemindable)@grain).@ReceiveReminder((global::System.String)arguments[0], (global::Orleans.Runtime.TickStatus)arguments[1]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -831689659 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -831689659;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.IGrainWithStringKey))]
    internal class OrleansCodeGenGrainWithStringKeyReference : global::Orleans.Runtime.GrainReference, global::Orleans.IGrainWithStringKey
    {
        protected @OrleansCodeGenGrainWithStringKeyReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenGrainWithStringKeyReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -1277021679;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.IGrainWithStringKey";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -1277021679;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -1277021679:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Orleans.IGrainWithStringKey", -1277021679, typeof (global::Orleans.IGrainWithStringKey)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenGrainWithStringKeyMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -1277021679:
                        switch (methodId)
                        {
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -1277021679;
            }
        }
    }
}

namespace Orleans.Streams
{
    using global::Orleans.Async;
    using global::Orleans;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Streams.IStreamQueueBalanceListener))]
    internal class OrleansCodeGenStreamQueueBalanceListenerReference : global::Orleans.Runtime.GrainReference, global::Orleans.Streams.IStreamQueueBalanceListener
    {
        protected @OrleansCodeGenStreamQueueBalanceListenerReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenStreamQueueBalanceListenerReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 2106004533;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Streams.IStreamQueueBalanceListener";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 2106004533;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 2106004533:
                    switch (@methodId)
                    {
                        case -1790343421:
                            return "QueueDistributionChangeNotification";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 2106004533 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @QueueDistributionChangeNotification()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1790343421, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Orleans.Streams.IStreamQueueBalanceListener", 2106004533, typeof (global::Orleans.Streams.IStreamQueueBalanceListener)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenStreamQueueBalanceListenerMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 2106004533:
                        switch (methodId)
                        {
                            case -1790343421:
                                return ((global::Orleans.Streams.IStreamQueueBalanceListener)@grain).@QueueDistributionChangeNotification().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 2106004533 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 2106004533;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Streams.IPersistentStreamPullingAgent))]
    internal class OrleansCodeGenPersistentStreamPullingAgentReference : global::Orleans.Runtime.GrainReference, global::Orleans.Streams.IPersistentStreamPullingAgent
    {
        protected @OrleansCodeGenPersistentStreamPullingAgentReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenPersistentStreamPullingAgentReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -2083502648;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Streams.IPersistentStreamPullingAgent";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -2083502648 || @interfaceId == 939373632;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -2083502648:
                    switch (@methodId)
                    {
                        case 1817704332:
                            return "Initialize";
                        case -2097507506:
                            return "Shutdown";
                        case 1447414468:
                            return "AddSubscriber";
                        case -1759922013:
                            return "RemoveSubscriber";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -2083502648 + ",methodId=" + @methodId);
                    }

                case 939373632:
                    switch (@methodId)
                    {
                        case 1447414468:
                            return "AddSubscriber";
                        case -1759922013:
                            return "RemoveSubscriber";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 939373632 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @Initialize(global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IQueueAdapter> @queueAdapter, global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IQueueAdapterCache> @queueAdapterCache, global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IStreamFailureHandler> @deliveryFailureHandler)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1817704332, new global::System.Object[]{@queueAdapter, @queueAdapterCache, @deliveryFailureHandler});
        }

        public global::System.Threading.Tasks.Task @Shutdown()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-2097507506, null);
        }

        public global::System.Threading.Tasks.Task @AddSubscriber(global::Orleans.Runtime.GuidId @subscriptionId, global::Orleans.Streams.StreamId @streamId, global::Orleans.Streams.IStreamConsumerExtension @streamConsumer, global::Orleans.Streams.IStreamFilterPredicateWrapper @filter)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1447414468, new global::System.Object[]{@subscriptionId, @streamId, @streamConsumer is global::Orleans.Grain ? @streamConsumer.@AsReference<global::Orleans.Streams.IStreamConsumerExtension>() : @streamConsumer, @filter}, options: global::Orleans.CodeGeneration.InvokeMethodOptions.@AlwaysInterleave);
        }

        public global::System.Threading.Tasks.Task @RemoveSubscriber(global::Orleans.Runtime.GuidId @subscriptionId, global::Orleans.Streams.StreamId @streamId)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1759922013, new global::System.Object[]{@subscriptionId, @streamId}, options: global::Orleans.CodeGeneration.InvokeMethodOptions.@AlwaysInterleave);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Orleans.Streams.IPersistentStreamPullingAgent", -2083502648, typeof (global::Orleans.Streams.IPersistentStreamPullingAgent)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenPersistentStreamPullingAgentMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker, global::Orleans.CodeGeneration.IGrainExtensionMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -2083502648:
                        switch (methodId)
                        {
                            case 1817704332:
                                return ((global::Orleans.Streams.IPersistentStreamPullingAgent)@grain).@Initialize((global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IQueueAdapter>)arguments[0], (global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IQueueAdapterCache>)arguments[1], (global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IStreamFailureHandler>)arguments[2]).@Box();
                            case -2097507506:
                                return ((global::Orleans.Streams.IPersistentStreamPullingAgent)@grain).@Shutdown().@Box();
                            case 1447414468:
                                return ((global::Orleans.Streams.IPersistentStreamPullingAgent)@grain).@AddSubscriber((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1], (global::Orleans.Streams.IStreamConsumerExtension)arguments[2], (global::Orleans.Streams.IStreamFilterPredicateWrapper)arguments[3]).@Box();
                            case -1759922013:
                                return ((global::Orleans.Streams.IPersistentStreamPullingAgent)@grain).@RemoveSubscriber((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -2083502648 + ",methodId=" + methodId);
                        }

                    case 939373632:
                        switch (methodId)
                        {
                            case 1447414468:
                                return ((global::Orleans.Streams.IPersistentStreamPullingAgent)@grain).@AddSubscriber((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1], (global::Orleans.Streams.IStreamConsumerExtension)arguments[2], (global::Orleans.Streams.IStreamFilterPredicateWrapper)arguments[3]).@Box();
                            case -1759922013:
                                return ((global::Orleans.Streams.IPersistentStreamPullingAgent)@grain).@RemoveSubscriber((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 939373632 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -2083502648;
            }
        }

        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IGrainExtension @extension, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@extension == null)
                    throw new global::System.ArgumentNullException("extension");
                switch (interfaceId)
                {
                    case -2083502648:
                        switch (methodId)
                        {
                            case 1817704332:
                                return ((global::Orleans.Streams.IPersistentStreamPullingAgent)@extension).@Initialize((global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IQueueAdapter>)arguments[0], (global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IQueueAdapterCache>)arguments[1], (global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IStreamFailureHandler>)arguments[2]).@Box();
                            case -2097507506:
                                return ((global::Orleans.Streams.IPersistentStreamPullingAgent)@extension).@Shutdown().@Box();
                            case 1447414468:
                                return ((global::Orleans.Streams.IPersistentStreamPullingAgent)@extension).@AddSubscriber((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1], (global::Orleans.Streams.IStreamConsumerExtension)arguments[2], (global::Orleans.Streams.IStreamFilterPredicateWrapper)arguments[3]).@Box();
                            case -1759922013:
                                return ((global::Orleans.Streams.IPersistentStreamPullingAgent)@extension).@RemoveSubscriber((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -2083502648 + ",methodId=" + methodId);
                        }

                    case 939373632:
                        switch (methodId)
                        {
                            case 1447414468:
                                return ((global::Orleans.Streams.IPersistentStreamPullingAgent)@extension).@AddSubscriber((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1], (global::Orleans.Streams.IStreamConsumerExtension)arguments[2], (global::Orleans.Streams.IStreamFilterPredicateWrapper)arguments[3]).@Box();
                            case -1759922013:
                                return ((global::Orleans.Streams.IPersistentStreamPullingAgent)@extension).@RemoveSubscriber((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 939373632 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Streams.IPersistentStreamPullingManager))]
    internal class OrleansCodeGenPersistentStreamPullingManagerReference : global::Orleans.Runtime.GrainReference, global::Orleans.Streams.IPersistentStreamPullingManager
    {
        protected @OrleansCodeGenPersistentStreamPullingManagerReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenPersistentStreamPullingManagerReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 789366386;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Streams.IPersistentStreamPullingManager";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 789366386;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 789366386:
                    switch (@methodId)
                    {
                        case -166879657:
                            return "Initialize";
                        case -1505116304:
                            return "Stop";
                        case -981473487:
                            return "StartAgents";
                        case -1266241283:
                            return "StopAgents";
                        case -906698655:
                            return "ExecuteCommand";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 789366386 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @Initialize(global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IQueueAdapter> @queueAdapter)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-166879657, new global::System.Object[]{@queueAdapter});
        }

        public global::System.Threading.Tasks.Task @Stop()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1505116304, null);
        }

        public global::System.Threading.Tasks.Task @StartAgents()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-981473487, null);
        }

        public global::System.Threading.Tasks.Task @StopAgents()
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1266241283, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Object> @ExecuteCommand(global::Orleans.Providers.Streams.Common.PersistentStreamProviderCommand @command, global::System.Object @arg)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-906698655, new global::System.Object[]{@command, @arg});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Orleans.Streams.IPersistentStreamPullingManager", 789366386, typeof (global::Orleans.Streams.IPersistentStreamPullingManager)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenPersistentStreamPullingManagerMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 789366386:
                        switch (methodId)
                        {
                            case -166879657:
                                return ((global::Orleans.Streams.IPersistentStreamPullingManager)@grain).@Initialize((global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IQueueAdapter>)arguments[0]).@Box();
                            case -1505116304:
                                return ((global::Orleans.Streams.IPersistentStreamPullingManager)@grain).@Stop().@Box();
                            case -981473487:
                                return ((global::Orleans.Streams.IPersistentStreamPullingManager)@grain).@StartAgents().@Box();
                            case -1266241283:
                                return ((global::Orleans.Streams.IPersistentStreamPullingManager)@grain).@StopAgents().@Box();
                            case -906698655:
                                return ((global::Orleans.Streams.IPersistentStreamPullingManager)@grain).@ExecuteCommand((global::Orleans.Providers.Streams.Common.PersistentStreamProviderCommand)arguments[0], (global::System.Object)arguments[1]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 789366386 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 789366386;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Streams.IStreamConsumerExtension))]
    internal class OrleansCodeGenStreamConsumerExtensionReference : global::Orleans.Runtime.GrainReference, global::Orleans.Streams.IStreamConsumerExtension
    {
        protected @OrleansCodeGenStreamConsumerExtensionReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenStreamConsumerExtensionReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1208535911;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Streams.IStreamConsumerExtension";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1208535911;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1208535911:
                    switch (@methodId)
                    {
                        case 692684254:
                            return "DeliverItem";
                        case -388181897:
                            return "DeliverBatch";
                        case -627903062:
                            return "CompleteStream";
                        case -1893107802:
                            return "ErrorInStream";
                        case -1402418353:
                            return "GetSequenceToken";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1208535911 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Streams.StreamHandshakeToken> @DeliverItem(global::Orleans.Runtime.GuidId @subscriptionId, global::Orleans.Concurrency.Immutable<global::System.Object> @item, global::Orleans.Streams.StreamSequenceToken @currentToken, global::Orleans.Streams.StreamHandshakeToken @handshakeToken)
        {
            return base.@InvokeMethodAsync<global::Orleans.Streams.StreamHandshakeToken>(692684254, new global::System.Object[]{@subscriptionId, @item, @currentToken, @handshakeToken});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Streams.StreamHandshakeToken> @DeliverBatch(global::Orleans.Runtime.GuidId @subscriptionId, global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IBatchContainer> @item, global::Orleans.Streams.StreamHandshakeToken @handshakeToken)
        {
            return base.@InvokeMethodAsync<global::Orleans.Streams.StreamHandshakeToken>(-388181897, new global::System.Object[]{@subscriptionId, @item, @handshakeToken});
        }

        public global::System.Threading.Tasks.Task @CompleteStream(global::Orleans.Runtime.GuidId @subscriptionId)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-627903062, new global::System.Object[]{@subscriptionId});
        }

        public global::System.Threading.Tasks.Task @ErrorInStream(global::Orleans.Runtime.GuidId @subscriptionId, global::System.Exception @exc)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1893107802, new global::System.Object[]{@subscriptionId, @exc});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Streams.StreamHandshakeToken> @GetSequenceToken(global::Orleans.Runtime.GuidId @subscriptionId)
        {
            return base.@InvokeMethodAsync<global::Orleans.Streams.StreamHandshakeToken>(-1402418353, new global::System.Object[]{@subscriptionId});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Orleans.Streams.IStreamConsumerExtension", 1208535911, typeof (global::Orleans.Streams.IStreamConsumerExtension)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenStreamConsumerExtensionMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker, global::Orleans.CodeGeneration.IGrainExtensionMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 1208535911:
                        switch (methodId)
                        {
                            case 692684254:
                                return ((global::Orleans.Streams.IStreamConsumerExtension)@grain).@DeliverItem((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Concurrency.Immutable<global::System.Object>)arguments[1], (global::Orleans.Streams.StreamSequenceToken)arguments[2], (global::Orleans.Streams.StreamHandshakeToken)arguments[3]).@Box();
                            case -388181897:
                                return ((global::Orleans.Streams.IStreamConsumerExtension)@grain).@DeliverBatch((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IBatchContainer>)arguments[1], (global::Orleans.Streams.StreamHandshakeToken)arguments[2]).@Box();
                            case -627903062:
                                return ((global::Orleans.Streams.IStreamConsumerExtension)@grain).@CompleteStream((global::Orleans.Runtime.GuidId)arguments[0]).@Box();
                            case -1893107802:
                                return ((global::Orleans.Streams.IStreamConsumerExtension)@grain).@ErrorInStream((global::Orleans.Runtime.GuidId)arguments[0], (global::System.Exception)arguments[1]).@Box();
                            case -1402418353:
                                return ((global::Orleans.Streams.IStreamConsumerExtension)@grain).@GetSequenceToken((global::Orleans.Runtime.GuidId)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1208535911 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1208535911;
            }
        }

        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IGrainExtension @extension, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@extension == null)
                    throw new global::System.ArgumentNullException("extension");
                switch (interfaceId)
                {
                    case 1208535911:
                        switch (methodId)
                        {
                            case 692684254:
                                return ((global::Orleans.Streams.IStreamConsumerExtension)@extension).@DeliverItem((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Concurrency.Immutable<global::System.Object>)arguments[1], (global::Orleans.Streams.StreamSequenceToken)arguments[2], (global::Orleans.Streams.StreamHandshakeToken)arguments[3]).@Box();
                            case -388181897:
                                return ((global::Orleans.Streams.IStreamConsumerExtension)@extension).@DeliverBatch((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Concurrency.Immutable<global::Orleans.Streams.IBatchContainer>)arguments[1], (global::Orleans.Streams.StreamHandshakeToken)arguments[2]).@Box();
                            case -627903062:
                                return ((global::Orleans.Streams.IStreamConsumerExtension)@extension).@CompleteStream((global::Orleans.Runtime.GuidId)arguments[0]).@Box();
                            case -1893107802:
                                return ((global::Orleans.Streams.IStreamConsumerExtension)@extension).@ErrorInStream((global::Orleans.Runtime.GuidId)arguments[0], (global::System.Exception)arguments[1]).@Box();
                            case -1402418353:
                                return ((global::Orleans.Streams.IStreamConsumerExtension)@extension).@GetSequenceToken((global::Orleans.Runtime.GuidId)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1208535911 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Streams.IStreamProducerExtension))]
    internal class OrleansCodeGenStreamProducerExtensionReference : global::Orleans.Runtime.GrainReference, global::Orleans.Streams.IStreamProducerExtension
    {
        protected @OrleansCodeGenStreamProducerExtensionReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenStreamProducerExtensionReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 939373632;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Streams.IStreamProducerExtension";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 939373632;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 939373632:
                    switch (@methodId)
                    {
                        case 1447414468:
                            return "AddSubscriber";
                        case -1759922013:
                            return "RemoveSubscriber";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 939373632 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @AddSubscriber(global::Orleans.Runtime.GuidId @subscriptionId, global::Orleans.Streams.StreamId @streamId, global::Orleans.Streams.IStreamConsumerExtension @streamConsumer, global::Orleans.Streams.IStreamFilterPredicateWrapper @filter)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1447414468, new global::System.Object[]{@subscriptionId, @streamId, @streamConsumer is global::Orleans.Grain ? @streamConsumer.@AsReference<global::Orleans.Streams.IStreamConsumerExtension>() : @streamConsumer, @filter}, options: global::Orleans.CodeGeneration.InvokeMethodOptions.@AlwaysInterleave);
        }

        public global::System.Threading.Tasks.Task @RemoveSubscriber(global::Orleans.Runtime.GuidId @subscriptionId, global::Orleans.Streams.StreamId @streamId)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1759922013, new global::System.Object[]{@subscriptionId, @streamId}, options: global::Orleans.CodeGeneration.InvokeMethodOptions.@AlwaysInterleave);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Orleans.Streams.IStreamProducerExtension", 939373632, typeof (global::Orleans.Streams.IStreamProducerExtension)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenStreamProducerExtensionMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker, global::Orleans.CodeGeneration.IGrainExtensionMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 939373632:
                        switch (methodId)
                        {
                            case 1447414468:
                                return ((global::Orleans.Streams.IStreamProducerExtension)@grain).@AddSubscriber((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1], (global::Orleans.Streams.IStreamConsumerExtension)arguments[2], (global::Orleans.Streams.IStreamFilterPredicateWrapper)arguments[3]).@Box();
                            case -1759922013:
                                return ((global::Orleans.Streams.IStreamProducerExtension)@grain).@RemoveSubscriber((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 939373632 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 939373632;
            }
        }

        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IGrainExtension @extension, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@extension == null)
                    throw new global::System.ArgumentNullException("extension");
                switch (interfaceId)
                {
                    case 939373632:
                        switch (methodId)
                        {
                            case 1447414468:
                                return ((global::Orleans.Streams.IStreamProducerExtension)@extension).@AddSubscriber((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1], (global::Orleans.Streams.IStreamConsumerExtension)arguments[2], (global::Orleans.Streams.IStreamFilterPredicateWrapper)arguments[3]).@Box();
                            case -1759922013:
                                return ((global::Orleans.Streams.IStreamProducerExtension)@extension).@RemoveSubscriber((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 939373632 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Streams.IPubSubRendezvousGrain))]
    internal class OrleansCodeGenPubSubRendezvousGrainReference : global::Orleans.Runtime.GrainReference, global::Orleans.Streams.IPubSubRendezvousGrain
    {
        protected @OrleansCodeGenPubSubRendezvousGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenPubSubRendezvousGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1746702088;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Streams.IPubSubRendezvousGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1746702088;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1746702088:
                    switch (@methodId)
                    {
                        case 912534711:
                            return "RegisterProducer";
                        case 1454606735:
                            return "UnregisterProducer";
                        case 1134142912:
                            return "RegisterConsumer";
                        case 1942100900:
                            return "UnregisterConsumer";
                        case 687623645:
                            return "ProducerCount";
                        case 1754136586:
                            return "ConsumerCount";
                        case -1264954998:
                            return "DiagGetConsumers";
                        case 1980500241:
                            return "Validate";
                        case 2028422179:
                            return "GetAllSubscriptions";
                        case -984771197:
                            return "FaultSubscription";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1746702088 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.ISet<global::Orleans.Streams.PubSubSubscriptionState>> @RegisterProducer(global::Orleans.Streams.StreamId @streamId, global::Orleans.Streams.IStreamProducerExtension @streamProducer)
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.ISet<global::Orleans.Streams.PubSubSubscriptionState>>(912534711, new global::System.Object[]{@streamId, @streamProducer is global::Orleans.Grain ? @streamProducer.@AsReference<global::Orleans.Streams.IStreamProducerExtension>() : @streamProducer});
        }

        public global::System.Threading.Tasks.Task @UnregisterProducer(global::Orleans.Streams.StreamId @streamId, global::Orleans.Streams.IStreamProducerExtension @streamProducer)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1454606735, new global::System.Object[]{@streamId, @streamProducer is global::Orleans.Grain ? @streamProducer.@AsReference<global::Orleans.Streams.IStreamProducerExtension>() : @streamProducer});
        }

        public global::System.Threading.Tasks.Task @RegisterConsumer(global::Orleans.Runtime.GuidId @subscriptionId, global::Orleans.Streams.StreamId @streamId, global::Orleans.Streams.IStreamConsumerExtension @streamConsumer, global::Orleans.Streams.IStreamFilterPredicateWrapper @filter)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1134142912, new global::System.Object[]{@subscriptionId, @streamId, @streamConsumer is global::Orleans.Grain ? @streamConsumer.@AsReference<global::Orleans.Streams.IStreamConsumerExtension>() : @streamConsumer, @filter});
        }

        public global::System.Threading.Tasks.Task @UnregisterConsumer(global::Orleans.Runtime.GuidId @subscriptionId, global::Orleans.Streams.StreamId @streamId)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1942100900, new global::System.Object[]{@subscriptionId, @streamId});
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @ProducerCount(global::Orleans.Streams.StreamId @streamId)
        {
            return base.@InvokeMethodAsync<global::System.Int32>(687623645, new global::System.Object[]{@streamId});
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @ConsumerCount(global::Orleans.Streams.StreamId @streamId)
        {
            return base.@InvokeMethodAsync<global::System.Int32>(1754136586, new global::System.Object[]{@streamId});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Streams.PubSubSubscriptionState[]> @DiagGetConsumers(global::Orleans.Streams.StreamId @streamId)
        {
            return base.@InvokeMethodAsync<global::Orleans.Streams.PubSubSubscriptionState[]>(-1264954998, new global::System.Object[]{@streamId});
        }

        public global::System.Threading.Tasks.Task @Validate()
        {
            return base.@InvokeMethodAsync<global::System.Object>(1980500241, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::Orleans.Runtime.GuidId>> @GetAllSubscriptions(global::Orleans.Streams.StreamId @streamId, global::Orleans.Streams.IStreamConsumerExtension @streamConsumer)
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.List<global::Orleans.Runtime.GuidId>>(2028422179, new global::System.Object[]{@streamId, @streamConsumer is global::Orleans.Grain ? @streamConsumer.@AsReference<global::Orleans.Streams.IStreamConsumerExtension>() : @streamConsumer});
        }

        public global::System.Threading.Tasks.Task @FaultSubscription(global::Orleans.Runtime.GuidId @subscriptionId)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-984771197, new global::System.Object[]{@subscriptionId});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Orleans.Streams.IPubSubRendezvousGrain", 1746702088, typeof (global::Orleans.Streams.IPubSubRendezvousGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenPubSubRendezvousGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 1746702088:
                        switch (methodId)
                        {
                            case 912534711:
                                return ((global::Orleans.Streams.IPubSubRendezvousGrain)@grain).@RegisterProducer((global::Orleans.Streams.StreamId)arguments[0], (global::Orleans.Streams.IStreamProducerExtension)arguments[1]).@Box();
                            case 1454606735:
                                return ((global::Orleans.Streams.IPubSubRendezvousGrain)@grain).@UnregisterProducer((global::Orleans.Streams.StreamId)arguments[0], (global::Orleans.Streams.IStreamProducerExtension)arguments[1]).@Box();
                            case 1134142912:
                                return ((global::Orleans.Streams.IPubSubRendezvousGrain)@grain).@RegisterConsumer((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1], (global::Orleans.Streams.IStreamConsumerExtension)arguments[2], (global::Orleans.Streams.IStreamFilterPredicateWrapper)arguments[3]).@Box();
                            case 1942100900:
                                return ((global::Orleans.Streams.IPubSubRendezvousGrain)@grain).@UnregisterConsumer((global::Orleans.Runtime.GuidId)arguments[0], (global::Orleans.Streams.StreamId)arguments[1]).@Box();
                            case 687623645:
                                return ((global::Orleans.Streams.IPubSubRendezvousGrain)@grain).@ProducerCount((global::Orleans.Streams.StreamId)arguments[0]).@Box();
                            case 1754136586:
                                return ((global::Orleans.Streams.IPubSubRendezvousGrain)@grain).@ConsumerCount((global::Orleans.Streams.StreamId)arguments[0]).@Box();
                            case -1264954998:
                                return ((global::Orleans.Streams.IPubSubRendezvousGrain)@grain).@DiagGetConsumers((global::Orleans.Streams.StreamId)arguments[0]).@Box();
                            case 1980500241:
                                return ((global::Orleans.Streams.IPubSubRendezvousGrain)@grain).@Validate().@Box();
                            case 2028422179:
                                return ((global::Orleans.Streams.IPubSubRendezvousGrain)@grain).@GetAllSubscriptions((global::Orleans.Streams.StreamId)arguments[0], (global::Orleans.Streams.IStreamConsumerExtension)arguments[1]).@Box();
                            case -984771197:
                                return ((global::Orleans.Streams.IPubSubRendezvousGrain)@grain).@FaultSubscription((global::Orleans.Runtime.GuidId)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1746702088 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1746702088;
            }
        }
    }
}

namespace Orleans.Storage
{
    using global::Orleans.Async;
    using global::Orleans;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Storage.IMemoryStorageGrain))]
    internal class OrleansCodeGenMemoryStorageGrainReference : global::Orleans.Runtime.GrainReference, global::Orleans.Storage.IMemoryStorageGrain
    {
        protected @OrleansCodeGenMemoryStorageGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenMemoryStorageGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 577125491;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Storage.IMemoryStorageGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 577125491;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 577125491:
                    switch (@methodId)
                    {
                        case -1395809340:
                            return "ReadStateAsync";
                        case -771347504:
                            return "WriteStateAsync";
                        case 1872309868:
                            return "DeleteStateAsync";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 577125491 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::Orleans.IGrainState> @ReadStateAsync(global::System.String @stateStore, global::System.String @grainStoreKey)
        {
            return base.@InvokeMethodAsync<global::Orleans.IGrainState>(-1395809340, new global::System.Object[]{@stateStore, @grainStoreKey});
        }

        public global::System.Threading.Tasks.Task<global::System.String> @WriteStateAsync(global::System.String @grainType, global::System.String @grainId, global::Orleans.IGrainState @grainState)
        {
            return base.@InvokeMethodAsync<global::System.String>(-771347504, new global::System.Object[]{@grainType, @grainId, @grainState});
        }

        public global::System.Threading.Tasks.Task @DeleteStateAsync(global::System.String @stateStore, global::System.String @grainStoreKey, global::System.String @eTag)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1872309868, new global::System.Object[]{@stateStore, @grainStoreKey, @eTag});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Orleans.Storage.IMemoryStorageGrain", 577125491, typeof (global::Orleans.Storage.IMemoryStorageGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenMemoryStorageGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 577125491:
                        switch (methodId)
                        {
                            case -1395809340:
                                return ((global::Orleans.Storage.IMemoryStorageGrain)@grain).@ReadStateAsync((global::System.String)arguments[0], (global::System.String)arguments[1]).@Box();
                            case -771347504:
                                return ((global::Orleans.Storage.IMemoryStorageGrain)@grain).@WriteStateAsync((global::System.String)arguments[0], (global::System.String)arguments[1], (global::Orleans.IGrainState)arguments[2]).@Box();
                            case 1872309868:
                                return ((global::Orleans.Storage.IMemoryStorageGrain)@grain).@DeleteStateAsync((global::System.String)arguments[0], (global::System.String)arguments[1], (global::System.String)arguments[2]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 577125491 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 577125491;
            }
        }
    }
}

namespace Orleans.Runtime
{
    using global::Orleans.Async;
    using global::Orleans;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Runtime.ITypeManager))]
    internal class OrleansCodeGenTypeManagerReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.ITypeManager
    {
        protected @OrleansCodeGenTypeManagerReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenTypeManagerReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 471740693;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Runtime.ITypeManager";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 471740693;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 471740693:
                    switch (@methodId)
                    {
                        case -1709237309:
                            return "GetTypeCodeMap";
                        case 1918315851:
                            return "GetImplicitStreamSubscriberTable";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 471740693 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Runtime.GrainInterfaceMap> @GetTypeCodeMap(global::Orleans.Runtime.SiloAddress @silo)
        {
            return base.@InvokeMethodAsync<global::Orleans.Runtime.GrainInterfaceMap>(-1709237309, new global::System.Object[]{@silo});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Streams.ImplicitStreamSubscriberTable> @GetImplicitStreamSubscriberTable(global::Orleans.Runtime.SiloAddress @silo)
        {
            return base.@InvokeMethodAsync<global::Orleans.Streams.ImplicitStreamSubscriberTable>(1918315851, new global::System.Object[]{@silo});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Orleans.Runtime.ITypeManager", 471740693, typeof (global::Orleans.Runtime.ITypeManager)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenTypeManagerMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 471740693:
                        switch (methodId)
                        {
                            case -1709237309:
                                return ((global::Orleans.Runtime.ITypeManager)@grain).@GetTypeCodeMap((global::Orleans.Runtime.SiloAddress)arguments[0]).@Box();
                            case 1918315851:
                                return ((global::Orleans.Runtime.ITypeManager)@grain).@GetImplicitStreamSubscriberTable((global::Orleans.Runtime.SiloAddress)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 471740693 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 471740693;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Runtime.ICatalog))]
    internal class OrleansCodeGenCatalogReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.ICatalog
    {
        protected @OrleansCodeGenCatalogReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenCatalogReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -2124089409;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Runtime.ICatalog";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -2124089409;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -2124089409:
                    switch (@methodId)
                    {
                        case -1850604271:
                            return "DeleteActivations";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -2124089409 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @DeleteActivations(global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress> @activationAddresses)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1850604271, new global::System.Object[]{@activationAddresses});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Orleans.Runtime.ICatalog", -2124089409, typeof (global::Orleans.Runtime.ICatalog)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenCatalogMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -2124089409:
                        switch (methodId)
                        {
                            case -1850604271:
                                return ((global::Orleans.Runtime.ICatalog)@grain).@DeleteActivations((global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -2124089409 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -2124089409;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Runtime.IManagementGrain))]
    internal class OrleansCodeGenManagementGrainReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IManagementGrain
    {
        protected @OrleansCodeGenManagementGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenManagementGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -1734666656;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Runtime.IManagementGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -1734666656;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -1734666656:
                    switch (@methodId)
                    {
                        case 1788323731:
                            return "GetHosts";
                        case 1345873229:
                            return "SetSystemLogLevel";
                        case -648657983:
                            return "SetAppLogLevel";
                        case -1683776832:
                            return "SetLogLevel";
                        case 2002650463:
                            return "ForceGarbageCollection";
                        case 316388927:
                            return "ForceActivationCollection";
                        case -2082132213:
                            return "ForceActivationCollection";
                        case 531832239:
                            return "ForceRuntimeStatisticsCollection";
                        case -1055610598:
                            return "GetRuntimeStatistics";
                        case -1446411211:
                            return "GetSimpleGrainStatistics";
                        case -1434082603:
                            return "GetSimpleGrainStatistics";
                        case -1868174702:
                            return "GetGrainActivationCount";
                        case -1030672010:
                            return "GetTotalActivationCount";
                        case -1426691790:
                            return "SendControlCommandToProvider";
                        case -1529190212:
                            return "UpdateConfiguration";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1734666656 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.SiloStatus>> @GetHosts(global::System.Boolean @onlyActive)
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.SiloStatus>>(1788323731, new global::System.Object[]{@onlyActive});
        }

        public global::System.Threading.Tasks.Task @SetSystemLogLevel(global::Orleans.Runtime.SiloAddress[] @hostsIds, global::System.Int32 @traceLevel)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1345873229, new global::System.Object[]{@hostsIds, @traceLevel});
        }

        public global::System.Threading.Tasks.Task @SetAppLogLevel(global::Orleans.Runtime.SiloAddress[] @hostsIds, global::System.Int32 @traceLevel)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-648657983, new global::System.Object[]{@hostsIds, @traceLevel});
        }

        public global::System.Threading.Tasks.Task @SetLogLevel(global::Orleans.Runtime.SiloAddress[] @hostsIds, global::System.String @logName, global::System.Int32 @traceLevel)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1683776832, new global::System.Object[]{@hostsIds, @logName, @traceLevel});
        }

        public global::System.Threading.Tasks.Task @ForceGarbageCollection(global::Orleans.Runtime.SiloAddress[] @hostsIds)
        {
            return base.@InvokeMethodAsync<global::System.Object>(2002650463, new global::System.Object[]{@hostsIds});
        }

        public global::System.Threading.Tasks.Task @ForceActivationCollection(global::Orleans.Runtime.SiloAddress[] @hostsIds, global::System.TimeSpan @ageLimit)
        {
            return base.@InvokeMethodAsync<global::System.Object>(316388927, new global::System.Object[]{@hostsIds, @ageLimit});
        }

        public global::System.Threading.Tasks.Task @ForceActivationCollection(global::System.TimeSpan @ageLimit)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-2082132213, new global::System.Object[]{@ageLimit});
        }

        public global::System.Threading.Tasks.Task @ForceRuntimeStatisticsCollection(global::Orleans.Runtime.SiloAddress[] @siloAddresses)
        {
            return base.@InvokeMethodAsync<global::System.Object>(531832239, new global::System.Object[]{@siloAddresses});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Runtime.SiloRuntimeStatistics[]> @GetRuntimeStatistics(global::Orleans.Runtime.SiloAddress[] @hostsIds)
        {
            return base.@InvokeMethodAsync<global::Orleans.Runtime.SiloRuntimeStatistics[]>(-1055610598, new global::System.Object[]{@hostsIds});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Runtime.SimpleGrainStatistic[]> @GetSimpleGrainStatistics(global::Orleans.Runtime.SiloAddress[] @hostsIds)
        {
            return base.@InvokeMethodAsync<global::Orleans.Runtime.SimpleGrainStatistic[]>(-1446411211, new global::System.Object[]{@hostsIds});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.Runtime.SimpleGrainStatistic[]> @GetSimpleGrainStatistics()
        {
            return base.@InvokeMethodAsync<global::Orleans.Runtime.SimpleGrainStatistic[]>(-1434082603, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @GetGrainActivationCount(global::Orleans.Runtime.GrainReference @grainReference)
        {
            return base.@InvokeMethodAsync<global::System.Int32>(-1868174702, new global::System.Object[]{@grainReference});
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @GetTotalActivationCount()
        {
            return base.@InvokeMethodAsync<global::System.Int32>(-1030672010, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Object[]> @SendControlCommandToProvider(global::System.String @providerTypeFullName, global::System.String @providerName, global::System.Int32 @command, global::System.Object @arg)
        {
            return base.@InvokeMethodAsync<global::System.Object[]>(-1426691790, new global::System.Object[]{@providerTypeFullName, @providerName, @command, @arg});
        }

        public global::System.Threading.Tasks.Task @UpdateConfiguration(global::Orleans.Runtime.SiloAddress[] @hostIds, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String> @configuration, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String> @tracing)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1529190212, new global::System.Object[]{@hostIds, @configuration, @tracing});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Orleans.Runtime.IManagementGrain", -1734666656, typeof (global::Orleans.Runtime.IManagementGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenManagementGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -1734666656:
                        switch (methodId)
                        {
                            case 1788323731:
                                return ((global::Orleans.Runtime.IManagementGrain)@grain).@GetHosts((global::System.Boolean)arguments[0]).@Box();
                            case 1345873229:
                                return ((global::Orleans.Runtime.IManagementGrain)@grain).@SetSystemLogLevel((global::Orleans.Runtime.SiloAddress[])arguments[0], (global::System.Int32)arguments[1]).@Box();
                            case -648657983:
                                return ((global::Orleans.Runtime.IManagementGrain)@grain).@SetAppLogLevel((global::Orleans.Runtime.SiloAddress[])arguments[0], (global::System.Int32)arguments[1]).@Box();
                            case -1683776832:
                                return ((global::Orleans.Runtime.IManagementGrain)@grain).@SetLogLevel((global::Orleans.Runtime.SiloAddress[])arguments[0], (global::System.String)arguments[1], (global::System.Int32)arguments[2]).@Box();
                            case 2002650463:
                                return ((global::Orleans.Runtime.IManagementGrain)@grain).@ForceGarbageCollection((global::Orleans.Runtime.SiloAddress[])arguments[0]).@Box();
                            case 316388927:
                                return ((global::Orleans.Runtime.IManagementGrain)@grain).@ForceActivationCollection((global::Orleans.Runtime.SiloAddress[])arguments[0], (global::System.TimeSpan)arguments[1]).@Box();
                            case -2082132213:
                                return ((global::Orleans.Runtime.IManagementGrain)@grain).@ForceActivationCollection((global::System.TimeSpan)arguments[0]).@Box();
                            case 531832239:
                                return ((global::Orleans.Runtime.IManagementGrain)@grain).@ForceRuntimeStatisticsCollection((global::Orleans.Runtime.SiloAddress[])arguments[0]).@Box();
                            case -1055610598:
                                return ((global::Orleans.Runtime.IManagementGrain)@grain).@GetRuntimeStatistics((global::Orleans.Runtime.SiloAddress[])arguments[0]).@Box();
                            case -1446411211:
                                return ((global::Orleans.Runtime.IManagementGrain)@grain).@GetSimpleGrainStatistics((global::Orleans.Runtime.SiloAddress[])arguments[0]).@Box();
                            case -1434082603:
                                return ((global::Orleans.Runtime.IManagementGrain)@grain).@GetSimpleGrainStatistics().@Box();
                            case -1868174702:
                                return ((global::Orleans.Runtime.IManagementGrain)@grain).@GetGrainActivationCount((global::Orleans.Runtime.GrainReference)arguments[0]).@Box();
                            case -1030672010:
                                return ((global::Orleans.Runtime.IManagementGrain)@grain).@GetTotalActivationCount().@Box();
                            case -1426691790:
                                return ((global::Orleans.Runtime.IManagementGrain)@grain).@SendControlCommandToProvider((global::System.String)arguments[0], (global::System.String)arguments[1], (global::System.Int32)arguments[2], (global::System.Object)arguments[3]).@Box();
                            case -1529190212:
                                return ((global::Orleans.Runtime.IManagementGrain)@grain).@UpdateConfiguration((global::Orleans.Runtime.SiloAddress[])arguments[0], (global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>)arguments[1], (global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>)arguments[2]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1734666656 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -1734666656;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Runtime.IMembershipService))]
    internal class OrleansCodeGenMembershipServiceReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IMembershipService
    {
        protected @OrleansCodeGenMembershipServiceReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenMembershipServiceReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1380110596;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Runtime.IMembershipService";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1380110596;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1380110596:
                    switch (@methodId)
                    {
                        case -378592564:
                            return "SiloStatusChangeNotification";
                        case 667017:
                            return "Ping";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1380110596 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @SiloStatusChangeNotification(global::Orleans.Runtime.SiloAddress @updatedSilo, global::Orleans.Runtime.SiloStatus @status)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-378592564, new global::System.Object[]{@updatedSilo, @status});
        }

        public global::System.Threading.Tasks.Task @Ping(global::System.Int32 @pingNumber)
        {
            return base.@InvokeMethodAsync<global::System.Object>(667017, new global::System.Object[]{@pingNumber});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Orleans.Runtime.IMembershipService", 1380110596, typeof (global::Orleans.Runtime.IMembershipService)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenMembershipServiceMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 1380110596:
                        switch (methodId)
                        {
                            case -378592564:
                                return ((global::Orleans.Runtime.IMembershipService)@grain).@SiloStatusChangeNotification((global::Orleans.Runtime.SiloAddress)arguments[0], (global::Orleans.Runtime.SiloStatus)arguments[1]).@Box();
                            case 667017:
                                return ((global::Orleans.Runtime.IMembershipService)@grain).@Ping((global::System.Int32)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1380110596 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1380110596;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Runtime.IRemoteGrainDirectory))]
    internal class OrleansCodeGenRemoteGrainDirectoryReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IRemoteGrainDirectory
    {
        protected @OrleansCodeGenRemoteGrainDirectoryReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenRemoteGrainDirectoryReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -185679256;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Runtime.IRemoteGrainDirectory";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -185679256;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -185679256:
                    switch (@methodId)
                    {
                        case 1407273934:
                            return "RegisterMany";
                        case 1942504603:
                            return "LookUpMany";
                        case -2026920982:
                            return "AcceptHandoffPartition";
                        case 1987552759:
                            return "RemoveHandoffPartition";
                        case 171163638:
                            return "RegisterAsync";
                        case 422358093:
                            return "UnregisterAsync";
                        case -1824874342:
                            return "UnregisterManyAsync";
                        case -1888800139:
                            return "DeleteGrainAsync";
                        case -1272744289:
                            return "LookupAsync";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -185679256 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @RegisterMany(global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress> @addresses, global::System.Boolean @singleActivation)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1407273934, new global::System.Object[]{@addresses, @singleActivation});
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.GrainId, global::System.Int32, global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>>>> @LookUpMany(global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.GrainId, global::System.Int32>> @grainAndETagList)
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.GrainId, global::System.Int32, global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>>>>(1942504603, new global::System.Object[]{@grainAndETagList});
        }

        public global::System.Threading.Tasks.Task @AcceptHandoffPartition(global::Orleans.Runtime.SiloAddress @source, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainId, global::Orleans.Runtime.IGrainInfo> @partition, global::System.Boolean @isFullCopy)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-2026920982, new global::System.Object[]{@source, @partition, @isFullCopy});
        }

        public global::System.Threading.Tasks.Task @RemoveHandoffPartition(global::Orleans.Runtime.SiloAddress @source)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1987552759, new global::System.Object[]{@source});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.GrainDirectory.AddressAndTag> @RegisterAsync(global::Orleans.Runtime.ActivationAddress @address, global::System.Boolean @singleActivation, global::System.Int32 @hopCount)
        {
            return base.@InvokeMethodAsync<global::Orleans.GrainDirectory.AddressAndTag>(171163638, new global::System.Object[]{@address, @singleActivation, @hopCount});
        }

        public global::System.Threading.Tasks.Task @UnregisterAsync(global::Orleans.Runtime.ActivationAddress @address, global::System.Boolean @force, global::System.Int32 @hopCount)
        {
            return base.@InvokeMethodAsync<global::System.Object>(422358093, new global::System.Object[]{@address, @force, @hopCount});
        }

        public global::System.Threading.Tasks.Task @UnregisterManyAsync(global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress> @addresses, global::System.Int32 @hopCount)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1824874342, new global::System.Object[]{@addresses, @hopCount});
        }

        public global::System.Threading.Tasks.Task @DeleteGrainAsync(global::Orleans.Runtime.GrainId @grainId, global::System.Int32 @hopCount)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1888800139, new global::System.Object[]{@grainId, @hopCount});
        }

        public global::System.Threading.Tasks.Task<global::Orleans.GrainDirectory.AddressesAndTag> @LookupAsync(global::Orleans.Runtime.GrainId @grainId, global::System.Int32 @hopCount)
        {
            return base.@InvokeMethodAsync<global::Orleans.GrainDirectory.AddressesAndTag>(-1272744289, new global::System.Object[]{@grainId, @hopCount});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Orleans.Runtime.IRemoteGrainDirectory", -185679256, typeof (global::Orleans.Runtime.IRemoteGrainDirectory)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenRemoteGrainDirectoryMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -185679256:
                        switch (methodId)
                        {
                            case 1407273934:
                                return ((global::Orleans.Runtime.IRemoteGrainDirectory)@grain).@RegisterMany((global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>)arguments[0], (global::System.Boolean)arguments[1]).@Box();
                            case 1942504603:
                                return ((global::Orleans.Runtime.IRemoteGrainDirectory)@grain).@LookUpMany((global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.GrainId, global::System.Int32>>)arguments[0]).@Box();
                            case -2026920982:
                                return ((global::Orleans.Runtime.IRemoteGrainDirectory)@grain).@AcceptHandoffPartition((global::Orleans.Runtime.SiloAddress)arguments[0], (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainId, global::Orleans.Runtime.IGrainInfo>)arguments[1], (global::System.Boolean)arguments[2]).@Box();
                            case 1987552759:
                                return ((global::Orleans.Runtime.IRemoteGrainDirectory)@grain).@RemoveHandoffPartition((global::Orleans.Runtime.SiloAddress)arguments[0]).@Box();
                            case 171163638:
                                return ((global::Orleans.Runtime.IRemoteGrainDirectory)@grain).@RegisterAsync((global::Orleans.Runtime.ActivationAddress)arguments[0], (global::System.Boolean)arguments[1], (global::System.Int32)arguments[2]).@Box();
                            case 422358093:
                                return ((global::Orleans.Runtime.IRemoteGrainDirectory)@grain).@UnregisterAsync((global::Orleans.Runtime.ActivationAddress)arguments[0], (global::System.Boolean)arguments[1], (global::System.Int32)arguments[2]).@Box();
                            case -1824874342:
                                return ((global::Orleans.Runtime.IRemoteGrainDirectory)@grain).@UnregisterManyAsync((global::System.Collections.Generic.List<global::Orleans.Runtime.ActivationAddress>)arguments[0], (global::System.Int32)arguments[1]).@Box();
                            case -1888800139:
                                return ((global::Orleans.Runtime.IRemoteGrainDirectory)@grain).@DeleteGrainAsync((global::Orleans.Runtime.GrainId)arguments[0], (global::System.Int32)arguments[1]).@Box();
                            case -1272744289:
                                return ((global::Orleans.Runtime.IRemoteGrainDirectory)@grain).@LookupAsync((global::Orleans.Runtime.GrainId)arguments[0], (global::System.Int32)arguments[1]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -185679256 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -185679256;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Runtime.IDeploymentLoadPublisher))]
    internal class OrleansCodeGenDeploymentLoadPublisherReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IDeploymentLoadPublisher
    {
        protected @OrleansCodeGenDeploymentLoadPublisherReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenDeploymentLoadPublisherReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -300889017;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Runtime.IDeploymentLoadPublisher";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -300889017;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -300889017:
                    switch (@methodId)
                    {
                        case 1787332004:
                            return "UpdateRuntimeStatistics";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -300889017 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @UpdateRuntimeStatistics(global::Orleans.Runtime.SiloAddress @siloAddress, global::Orleans.Runtime.SiloRuntimeStatistics @siloStats)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1787332004, new global::System.Object[]{@siloAddress, @siloStats});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Orleans.Runtime.IDeploymentLoadPublisher", -300889017, typeof (global::Orleans.Runtime.IDeploymentLoadPublisher)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenDeploymentLoadPublisherMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -300889017:
                        switch (methodId)
                        {
                            case 1787332004:
                                return ((global::Orleans.Runtime.IDeploymentLoadPublisher)@grain).@UpdateRuntimeStatistics((global::Orleans.Runtime.SiloAddress)arguments[0], (global::Orleans.Runtime.SiloRuntimeStatistics)arguments[1]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -300889017 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -300889017;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.Runtime.IClientObserverRegistrar))]
    internal class OrleansCodeGenClientObserverRegistrarReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IClientObserverRegistrar
    {
        protected @OrleansCodeGenClientObserverRegistrarReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenClientObserverRegistrarReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -241055592;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.Runtime.IClientObserverRegistrar";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -241055592;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -241055592:
                    switch (@methodId)
                    {
                        case 1420312199:
                            return "Start";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -241055592 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @Start()
        {
            return base.@InvokeMethodAsync<global::System.Object>(1420312199, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Orleans.Runtime.IClientObserverRegistrar", -241055592, typeof (global::Orleans.Runtime.IClientObserverRegistrar)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenClientObserverRegistrarMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -241055592:
                        switch (methodId)
                        {
                            case 1420312199:
                                return ((global::Orleans.Runtime.IClientObserverRegistrar)@grain).@Start().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -241055592 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -241055592;
            }
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
