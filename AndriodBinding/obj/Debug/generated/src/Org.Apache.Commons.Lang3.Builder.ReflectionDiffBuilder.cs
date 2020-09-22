using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Builder {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionDiffBuilder']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/builder/ReflectionDiffBuilder", DoNotGenerateAcw=true)]
	public partial class ReflectionDiffBuilder : global::Java.Lang.Object, global::Org.Apache.Commons.Lang3.Builder.IBuilder {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/builder/ReflectionDiffBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReflectionDiffBuilder); }
		}

		protected ReflectionDiffBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Object_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionDiffBuilder']/constructor[@name='ReflectionDiffBuilder' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='T'] and parameter[3][@type='org.apache.commons.lang3.builder.ToStringStyle']]"
		[Register (".ctor", "(Ljava/lang/Object;Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;)V", "")]
		public unsafe ReflectionDiffBuilder (global::Java.Lang.Object lhs, global::Java.Lang.Object rhs, global::Org.Apache.Commons.Lang3.Builder.ToStringStyle style)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_lhs = JNIEnv.ToLocalJniHandle (lhs);
			IntPtr native_rhs = JNIEnv.ToLocalJniHandle (rhs);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_lhs);
				__args [1] = new JValue (native_rhs);
				__args [2] = new JValue (style);
				if (((object) this).GetType () != typeof (ReflectionDiffBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Object;Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Ljava/lang/Object;Lorg/apache/commons/lang3/builder/ToStringStyle;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_Lorg_apache_commons_lang3_builder_ToStringStyle_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_lhs);
				JNIEnv.DeleteLocalRef (native_rhs);
			}
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ReflectionDiffBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		static IntPtr id_build;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='ReflectionDiffBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lorg/apache/commons/lang3/builder/DiffResult;", "GetBuildHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.DiffResult Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lorg/apache/commons/lang3/builder/DiffResult;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lorg/apache/commons/lang3/builder/DiffResult;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Org.Apache.Commons.Lang3.Builder.IBuilder
		global::Java.Lang.Object global::Org.Apache.Commons.Lang3.Builder.IBuilder.Build ()
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(Build ());
		}

	}
}
