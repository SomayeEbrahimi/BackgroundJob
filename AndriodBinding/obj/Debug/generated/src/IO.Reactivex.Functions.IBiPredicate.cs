using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Functions {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex.functions']/interface[@name='BiPredicate']"
	[Register ("io/reactivex/functions/BiPredicate", "", "IO.Reactivex.Functions.IBiPredicateInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2"})]
	public partial interface IBiPredicate : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.functions']/interface[@name='BiPredicate']/method[@name='test' and count(parameter)=2 and parameter[1][@type='T1'] and parameter[2][@type='T2']]"
		[Register ("test", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "GetTest_Ljava_lang_Object_Ljava_lang_Object_Handler:IO.Reactivex.Functions.IBiPredicateInvoker, AndriodBinding")]
		bool Test (global::Java.Lang.Object p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("io/reactivex/functions/BiPredicate", DoNotGenerateAcw=true)]
	internal partial class IBiPredicateInvoker : global::Java.Lang.Object, IBiPredicate {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/functions/BiPredicate");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiPredicateInvoker); }
		}

		IntPtr class_ref;

		public static IBiPredicate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiPredicate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.functions.BiPredicate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiPredicateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_test_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetTest_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_test_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_test_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_Test_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_test_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static bool n_Test_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IBiPredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Test (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_test_Ljava_lang_Object_Ljava_lang_Object_;
		public unsafe bool Test (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_test_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_test_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "test", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_test_Ljava_lang_Object_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}

}
