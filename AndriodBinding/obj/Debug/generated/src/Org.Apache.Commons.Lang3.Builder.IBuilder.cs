using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Builder {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.apache.commons.lang3.builder']/interface[@name='Builder']"
	[Register ("org/apache/commons/lang3/builder/Builder", "", "Org.Apache.Commons.Lang3.Builder.IBuilderInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IBuilder : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/interface[@name='Builder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Ljava/lang/Object;", "GetBuildHandler:Org.Apache.Commons.Lang3.Builder.IBuilderInvoker, AndriodBinding")]
		global::Java.Lang.Object Build ();

	}

	[global::Android.Runtime.Register ("org/apache/commons/lang3/builder/Builder", DoNotGenerateAcw=true)]
	internal partial class IBuilderInvoker : global::Java.Lang.Object, IBuilder {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/apache/commons/lang3/builder/Builder");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBuilderInvoker); }
		}

		IntPtr class_ref;

		public static IBuilder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBuilder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.apache.commons.lang3.builder.Builder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.IBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		IntPtr id_build;
		public unsafe global::Java.Lang.Object Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
		}

	}

}
