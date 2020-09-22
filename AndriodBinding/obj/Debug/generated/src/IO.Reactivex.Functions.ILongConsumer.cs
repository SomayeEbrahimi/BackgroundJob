using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Functions {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex.functions']/interface[@name='LongConsumer']"
	[Register ("io/reactivex/functions/LongConsumer", "", "IO.Reactivex.Functions.ILongConsumerInvoker")]
	public partial interface ILongConsumer : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.functions']/interface[@name='LongConsumer']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("accept", "(J)V", "GetAccept_JHandler:IO.Reactivex.Functions.ILongConsumerInvoker, AndriodBinding")]
		void Accept (long p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/functions/LongConsumer", DoNotGenerateAcw=true)]
	internal partial class ILongConsumerInvoker : global::Java.Lang.Object, ILongConsumer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/functions/LongConsumer");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILongConsumerInvoker); }
		}

		IntPtr class_ref;

		public static ILongConsumer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILongConsumer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.functions.LongConsumer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILongConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_accept_J;
#pragma warning disable 0169
		static Delegate GetAccept_JHandler ()
		{
			if (cb_accept_J == null)
				cb_accept_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_Accept_J);
			return cb_accept_J;
		}

		static void n_Accept_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.ILongConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Accept (p0);
		}
#pragma warning restore 0169

		IntPtr id_accept_J;
		public unsafe void Accept (long p0)
		{
			if (id_accept_J == IntPtr.Zero)
				id_accept_J = JNIEnv.GetMethodID (class_ref, "accept", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_accept_J, __args);
		}

	}

}
