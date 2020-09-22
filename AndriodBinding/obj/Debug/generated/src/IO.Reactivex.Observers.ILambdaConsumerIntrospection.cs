using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Observers {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex.observers']/interface[@name='LambdaConsumerIntrospection']"
	[Register ("io/reactivex/observers/LambdaConsumerIntrospection", "", "IO.Reactivex.Observers.ILambdaConsumerIntrospectionInvoker")]
	public partial interface ILambdaConsumerIntrospection : IJavaObject {

		bool HasCustomOnError {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/interface[@name='LambdaConsumerIntrospection']/method[@name='hasCustomOnError' and count(parameter)=0]"
			[Register ("hasCustomOnError", "()Z", "GetHasCustomOnErrorHandler:IO.Reactivex.Observers.ILambdaConsumerIntrospectionInvoker, AndriodBinding")] get;
		}

	}

	[global::Android.Runtime.Register ("io/reactivex/observers/LambdaConsumerIntrospection", DoNotGenerateAcw=true)]
	internal partial class ILambdaConsumerIntrospectionInvoker : global::Java.Lang.Object, ILambdaConsumerIntrospection {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/observers/LambdaConsumerIntrospection");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILambdaConsumerIntrospectionInvoker); }
		}

		IntPtr class_ref;

		public static ILambdaConsumerIntrospection GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILambdaConsumerIntrospection> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.observers.LambdaConsumerIntrospection"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILambdaConsumerIntrospectionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_hasCustomOnError;
#pragma warning disable 0169
		static Delegate GetHasCustomOnErrorHandler ()
		{
			if (cb_hasCustomOnError == null)
				cb_hasCustomOnError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasCustomOnError);
			return cb_hasCustomOnError;
		}

		static bool n_HasCustomOnError (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.ILambdaConsumerIntrospection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasCustomOnError;
		}
#pragma warning restore 0169

		IntPtr id_hasCustomOnError;
		public unsafe bool HasCustomOnError {
			get {
				if (id_hasCustomOnError == IntPtr.Zero)
					id_hasCustomOnError = JNIEnv.GetMethodID (class_ref, "hasCustomOnError", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasCustomOnError);
			}
		}

	}

}
