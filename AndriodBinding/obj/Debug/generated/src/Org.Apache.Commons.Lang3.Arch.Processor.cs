using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Arch {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.arch']/class[@name='Processor']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/arch/Processor", DoNotGenerateAcw=true)]
	public partial class Processor : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.arch']/class[@name='Processor.Arch']"
		[global::Android.Runtime.Register ("org/apache/commons/lang3/arch/Processor$Arch", DoNotGenerateAcw=true)]
		public sealed partial class Arch : global::Java.Lang.Enum {


			static IntPtr BIT_32_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.arch']/class[@name='Processor.Arch']/field[@name='BIT_32']"
			[Register ("BIT_32")]
			public static global::Org.Apache.Commons.Lang3.Arch.Processor.Arch Bit32 {
				get {
					if (BIT_32_jfieldId == IntPtr.Zero)
						BIT_32_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BIT_32", "Lorg/apache/commons/lang3/arch/Processor$Arch;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BIT_32_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Arch.Processor.Arch> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BIT_64_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.arch']/class[@name='Processor.Arch']/field[@name='BIT_64']"
			[Register ("BIT_64")]
			public static global::Org.Apache.Commons.Lang3.Arch.Processor.Arch Bit64 {
				get {
					if (BIT_64_jfieldId == IntPtr.Zero)
						BIT_64_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BIT_64", "Lorg/apache/commons/lang3/arch/Processor$Arch;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BIT_64_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Arch.Processor.Arch> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.arch']/class[@name='Processor.Arch']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Org.Apache.Commons.Lang3.Arch.Processor.Arch Unknown {
				get {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lorg/apache/commons/lang3/arch/Processor$Arch;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Arch.Processor.Arch> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/apache/commons/lang3/arch/Processor$Arch", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Arch); }
			}

			internal Arch (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.arch']/class[@name='Processor.Arch']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/apache/commons/lang3/arch/Processor$Arch;", "")]
			public static unsafe global::Org.Apache.Commons.Lang3.Arch.Processor.Arch ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/apache/commons/lang3/arch/Processor$Arch;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Org.Apache.Commons.Lang3.Arch.Processor.Arch __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Arch.Processor.Arch> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.arch']/class[@name='Processor.Arch']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/apache/commons/lang3/arch/Processor$Arch;", "")]
			public static unsafe global::Org.Apache.Commons.Lang3.Arch.Processor.Arch[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/apache/commons/lang3/arch/Processor$Arch;");
				try {
					return (global::Org.Apache.Commons.Lang3.Arch.Processor.Arch[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Apache.Commons.Lang3.Arch.Processor.Arch));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.arch']/class[@name='Processor.Type']"
		[global::Android.Runtime.Register ("org/apache/commons/lang3/arch/Processor$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr IA_64_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.arch']/class[@name='Processor.Type']/field[@name='IA_64']"
			[Register ("IA_64")]
			public static global::Org.Apache.Commons.Lang3.Arch.Processor.Type Ia64 {
				get {
					if (IA_64_jfieldId == IntPtr.Zero)
						IA_64_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IA_64", "Lorg/apache/commons/lang3/arch/Processor$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IA_64_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Arch.Processor.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PPC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.arch']/class[@name='Processor.Type']/field[@name='PPC']"
			[Register ("PPC")]
			public static global::Org.Apache.Commons.Lang3.Arch.Processor.Type Ppc {
				get {
					if (PPC_jfieldId == IntPtr.Zero)
						PPC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PPC", "Lorg/apache/commons/lang3/arch/Processor$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PPC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Arch.Processor.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.arch']/class[@name='Processor.Type']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Org.Apache.Commons.Lang3.Arch.Processor.Type Unknown {
				get {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lorg/apache/commons/lang3/arch/Processor$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Arch.Processor.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr X86_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.arch']/class[@name='Processor.Type']/field[@name='X86']"
			[Register ("X86")]
			public static global::Org.Apache.Commons.Lang3.Arch.Processor.Type X86 {
				get {
					if (X86_jfieldId == IntPtr.Zero)
						X86_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "X86", "Lorg/apache/commons/lang3/arch/Processor$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, X86_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Arch.Processor.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/apache/commons/lang3/arch/Processor$Type", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Type); }
			}

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.arch']/class[@name='Processor.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/apache/commons/lang3/arch/Processor$Type;", "")]
			public static unsafe global::Org.Apache.Commons.Lang3.Arch.Processor.Type ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/apache/commons/lang3/arch/Processor$Type;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Org.Apache.Commons.Lang3.Arch.Processor.Type __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Arch.Processor.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.arch']/class[@name='Processor.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/apache/commons/lang3/arch/Processor$Type;", "")]
			public static unsafe global::Org.Apache.Commons.Lang3.Arch.Processor.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/apache/commons/lang3/arch/Processor$Type;");
				try {
					return (global::Org.Apache.Commons.Lang3.Arch.Processor.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Apache.Commons.Lang3.Arch.Processor.Type));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/arch/Processor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Processor); }
		}

		protected Processor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_apache_commons_lang3_arch_Processor_Arch_Lorg_apache_commons_lang3_arch_Processor_Type_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.arch']/class[@name='Processor']/constructor[@name='Processor' and count(parameter)=2 and parameter[1][@type='org.apache.commons.lang3.arch.Processor.Arch'] and parameter[2][@type='org.apache.commons.lang3.arch.Processor.Type']]"
		[Register (".ctor", "(Lorg/apache/commons/lang3/arch/Processor$Arch;Lorg/apache/commons/lang3/arch/Processor$Type;)V", "")]
		public unsafe Processor (global::Org.Apache.Commons.Lang3.Arch.Processor.Arch arch, global::Org.Apache.Commons.Lang3.Arch.Processor.Type type)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (arch);
				__args [1] = new JValue (type);
				if (((object) this).GetType () != typeof (Processor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/apache/commons/lang3/arch/Processor$Arch;Lorg/apache/commons/lang3/arch/Processor$Type;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/apache/commons/lang3/arch/Processor$Arch;Lorg/apache/commons/lang3/arch/Processor$Type;)V", __args);
					return;
				}

				if (id_ctor_Lorg_apache_commons_lang3_arch_Processor_Arch_Lorg_apache_commons_lang3_arch_Processor_Type_ == IntPtr.Zero)
					id_ctor_Lorg_apache_commons_lang3_arch_Processor_Arch_Lorg_apache_commons_lang3_arch_Processor_Type_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/commons/lang3/arch/Processor$Arch;Lorg/apache/commons/lang3/arch/Processor$Type;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_commons_lang3_arch_Processor_Arch_Lorg_apache_commons_lang3_arch_Processor_Type_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_apache_commons_lang3_arch_Processor_Arch_Lorg_apache_commons_lang3_arch_Processor_Type_, __args);
			} finally {
			}
		}

		static Delegate cb_isIA64;
#pragma warning disable 0169
		static Delegate GetIsIA64Handler ()
		{
			if (cb_isIA64 == null)
				cb_isIA64 = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsIA64);
			return cb_isIA64;
		}

		static bool n_IsIA64 (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Arch.Processor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsIA64;
		}
#pragma warning restore 0169

		static IntPtr id_isIA64;
		public virtual unsafe bool IsIA64 {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.arch']/class[@name='Processor']/method[@name='isIA64' and count(parameter)=0]"
			[Register ("isIA64", "()Z", "GetIsIA64Handler")]
			get {
				if (id_isIA64 == IntPtr.Zero)
					id_isIA64 = JNIEnv.GetMethodID (class_ref, "isIA64", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isIA64);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isIA64", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isPPC;
#pragma warning disable 0169
		static Delegate GetIsPPCHandler ()
		{
			if (cb_isPPC == null)
				cb_isPPC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPPC);
			return cb_isPPC;
		}

		static bool n_IsPPC (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Arch.Processor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPPC;
		}
#pragma warning restore 0169

		static IntPtr id_isPPC;
		public virtual unsafe bool IsPPC {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.arch']/class[@name='Processor']/method[@name='isPPC' and count(parameter)=0]"
			[Register ("isPPC", "()Z", "GetIsPPCHandler")]
			get {
				if (id_isPPC == IntPtr.Zero)
					id_isPPC = JNIEnv.GetMethodID (class_ref, "isPPC", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPPC);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPPC", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isX86;
#pragma warning disable 0169
		static Delegate GetIsX86Handler ()
		{
			if (cb_isX86 == null)
				cb_isX86 = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsX86);
			return cb_isX86;
		}

		static bool n_IsX86 (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Arch.Processor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsX86;
		}
#pragma warning restore 0169

		static IntPtr id_isX86;
		public virtual unsafe bool IsX86 {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.arch']/class[@name='Processor']/method[@name='isX86' and count(parameter)=0]"
			[Register ("isX86", "()Z", "GetIsX86Handler")]
			get {
				if (id_isX86 == IntPtr.Zero)
					id_isX86 = JNIEnv.GetMethodID (class_ref, "isX86", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isX86);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isX86", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getArch;
#pragma warning disable 0169
		static Delegate GetGetArchHandler ()
		{
			if (cb_getArch == null)
				cb_getArch = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetArch);
			return cb_getArch;
		}

		static IntPtr n_GetArch (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Arch.Processor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetArch ());
		}
#pragma warning restore 0169

		static IntPtr id_getArch;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.arch']/class[@name='Processor']/method[@name='getArch' and count(parameter)=0]"
		[Register ("getArch", "()Lorg/apache/commons/lang3/arch/Processor$Arch;", "GetGetArchHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Arch.Processor.Arch GetArch ()
		{
			if (id_getArch == IntPtr.Zero)
				id_getArch = JNIEnv.GetMethodID (class_ref, "getArch", "()Lorg/apache/commons/lang3/arch/Processor$Arch;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Arch.Processor.Arch> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getArch), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Arch.Processor.Arch> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getArch", "()Lorg/apache/commons/lang3/arch/Processor$Arch;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Arch.Processor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetType ());
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.arch']/class[@name='Processor']/method[@name='getType' and count(parameter)=0]"
		[Register ("getType", "()Lorg/apache/commons/lang3/arch/Processor$Type;", "GetGetTypeHandler")]
		public new virtual unsafe global::Org.Apache.Commons.Lang3.Arch.Processor.Type GetType ()
		{
			if (id_getType == IntPtr.Zero)
				id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lorg/apache/commons/lang3/arch/Processor$Type;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Arch.Processor.Type> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Arch.Processor.Type> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Lorg/apache/commons/lang3/arch/Processor$Type;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_is32Bit;
#pragma warning disable 0169
		static Delegate GetIs32BitHandler ()
		{
			if (cb_is32Bit == null)
				cb_is32Bit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Is32Bit);
			return cb_is32Bit;
		}

		static bool n_Is32Bit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Arch.Processor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is32Bit ();
		}
#pragma warning restore 0169

		static IntPtr id_is32Bit;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.arch']/class[@name='Processor']/method[@name='is32Bit' and count(parameter)=0]"
		[Register ("is32Bit", "()Z", "GetIs32BitHandler")]
		public virtual unsafe bool Is32Bit ()
		{
			if (id_is32Bit == IntPtr.Zero)
				id_is32Bit = JNIEnv.GetMethodID (class_ref, "is32Bit", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_is32Bit);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "is32Bit", "()Z"));
			} finally {
			}
		}

		static Delegate cb_is64Bit;
#pragma warning disable 0169
		static Delegate GetIs64BitHandler ()
		{
			if (cb_is64Bit == null)
				cb_is64Bit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Is64Bit);
			return cb_is64Bit;
		}

		static bool n_Is64Bit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Arch.Processor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is64Bit ();
		}
#pragma warning restore 0169

		static IntPtr id_is64Bit;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.arch']/class[@name='Processor']/method[@name='is64Bit' and count(parameter)=0]"
		[Register ("is64Bit", "()Z", "GetIs64BitHandler")]
		public virtual unsafe bool Is64Bit ()
		{
			if (id_is64Bit == IntPtr.Zero)
				id_is64Bit = JNIEnv.GetMethodID (class_ref, "is64Bit", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_is64Bit);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "is64Bit", "()Z"));
			} finally {
			}
		}

	}
}
