using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Functions {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex.functions']/interface[@name='Consumer']"
	[Register ("io/reactivex/functions/Consumer", "", "IO.Reactivex.Functions.IConsumerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IConsumer : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.functions']/interface[@name='Consumer']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("accept", "(Ljava/lang/Object;)V", "GetAccept_Ljava_lang_Object_Handler:IO.Reactivex.Functions.IConsumerInvoker, AndriodBinding")]
		void Accept (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/functions/Consumer", DoNotGenerateAcw=true)]
	internal partial class IConsumerInvoker : global::Java.Lang.Object, IConsumer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/functions/Consumer");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IConsumerInvoker); }
		}

		IntPtr class_ref;

		public static IConsumer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConsumer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.functions.Consumer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_accept_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAccept_Ljava_lang_Object_Handler ()
		{
			if (cb_accept_Ljava_lang_Object_ == null)
				cb_accept_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Accept_Ljava_lang_Object_);
			return cb_accept_Ljava_lang_Object_;
		}

		static void n_Accept_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Accept (p0);
		}
#pragma warning restore 0169

		IntPtr id_accept_Ljava_lang_Object_;
		public unsafe void Accept (global::Java.Lang.Object p0)
		{
			if (id_accept_Ljava_lang_Object_ == IntPtr.Zero)
				id_accept_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "accept", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_accept_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
