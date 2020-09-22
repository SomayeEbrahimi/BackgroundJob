using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Builder {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.apache.commons.lang3.builder']/interface[@name='Diffable']"
	[Register ("org/apache/commons/lang3/builder/Diffable", "", "Org.Apache.Commons.Lang3.Builder.IDiffableInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IDiffable : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/interface[@name='Diffable']/method[@name='diff' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("diff", "(Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/DiffResult;", "GetDiff_Ljava_lang_Object_Handler:Org.Apache.Commons.Lang3.Builder.IDiffableInvoker, AndriodBinding")]
		global::Org.Apache.Commons.Lang3.Builder.DiffResult Diff (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("org/apache/commons/lang3/builder/Diffable", DoNotGenerateAcw=true)]
	internal partial class IDiffableInvoker : global::Java.Lang.Object, IDiffable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/apache/commons/lang3/builder/Diffable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDiffableInvoker); }
		}

		IntPtr class_ref;

		public static IDiffable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDiffable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.apache.commons.lang3.builder.Diffable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDiffableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_diff_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDiff_Ljava_lang_Object_Handler ()
		{
			if (cb_diff_Ljava_lang_Object_ == null)
				cb_diff_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Diff_Ljava_lang_Object_);
			return cb_diff_Ljava_lang_Object_;
		}

		static IntPtr n_Diff_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.IDiffable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Diff (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_diff_Ljava_lang_Object_;
		public unsafe global::Org.Apache.Commons.Lang3.Builder.DiffResult Diff (global::Java.Lang.Object p0)
		{
			if (id_diff_Ljava_lang_Object_ == IntPtr.Zero)
				id_diff_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "diff", "(Ljava/lang/Object;)Lorg/apache/commons/lang3/builder/DiffResult;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_diff_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
