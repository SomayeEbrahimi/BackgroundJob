using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Aspectj.Internal.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='TypePatternBasedPerClauseImpl']"
	[global::Android.Runtime.Register ("org/aspectj/internal/lang/reflect/TypePatternBasedPerClauseImpl", DoNotGenerateAcw=true)]
	public partial class TypePatternBasedPerClauseImpl : global::Org.Aspectj.Internal.Lang.Reflect.PerClauseImpl, global::Org.Aspectj.Lang.Reflect.ITypePatternBasedPerClause {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/aspectj/internal/lang/reflect/TypePatternBasedPerClauseImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TypePatternBasedPerClauseImpl); }
		}

		protected TypePatternBasedPerClauseImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_aspectj_lang_reflect_PerClauseKind_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='TypePatternBasedPerClauseImpl']/constructor[@name='TypePatternBasedPerClauseImpl' and count(parameter)=2 and parameter[1][@type='org.aspectj.lang.reflect.PerClauseKind'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lorg/aspectj/lang/reflect/PerClauseKind;Ljava/lang/String;)V", "")]
		public unsafe TypePatternBasedPerClauseImpl (global::Org.Aspectj.Lang.Reflect.PerClauseKind kind, string pattern)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (kind);
				__args [1] = new JValue (native_pattern);
				if (((object) this).GetType () != typeof (TypePatternBasedPerClauseImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/aspectj/lang/reflect/PerClauseKind;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/aspectj/lang/reflect/PerClauseKind;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lorg_aspectj_lang_reflect_PerClauseKind_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lorg_aspectj_lang_reflect_PerClauseKind_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/aspectj/lang/reflect/PerClauseKind;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_aspectj_lang_reflect_PerClauseKind_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_aspectj_lang_reflect_PerClauseKind_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

		static Delegate cb_getTypePattern;
#pragma warning disable 0169
		static Delegate GetGetTypePatternHandler ()
		{
			if (cb_getTypePattern == null)
				cb_getTypePattern = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTypePattern);
			return cb_getTypePattern;
		}

		static IntPtr n_GetTypePattern (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.TypePatternBasedPerClauseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TypePattern);
		}
#pragma warning restore 0169

		static IntPtr id_getTypePattern;
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.ITypePattern TypePattern {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='TypePatternBasedPerClauseImpl']/method[@name='getTypePattern' and count(parameter)=0]"
			[Register ("getTypePattern", "()Lorg/aspectj/lang/reflect/TypePattern;", "GetGetTypePatternHandler")]
			get {
				if (id_getTypePattern == IntPtr.Zero)
					id_getTypePattern = JNIEnv.GetMethodID (class_ref, "getTypePattern", "()Lorg/aspectj/lang/reflect/TypePattern;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ITypePattern> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTypePattern), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ITypePattern> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTypePattern", "()Lorg/aspectj/lang/reflect/TypePattern;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
