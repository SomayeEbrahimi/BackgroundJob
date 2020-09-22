using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Single {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.single']/class[@name='SingleOnErrorReturn']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/single/SingleOnErrorReturn", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class SingleOnErrorReturn : global::IO.Reactivex.Single {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/single/SingleOnErrorReturn", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SingleOnErrorReturn); }
		}

		internal SingleOnErrorReturn (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.single']/class[@name='SingleOnErrorReturn']/constructor[@name='SingleOnErrorReturn' and count(parameter)=3 and parameter[1][@type='io.reactivex.SingleSource&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super java.lang.Throwable, ? extends T&gt;'] and parameter[3][@type='T']]"
		[Register (".ctor", "(Lio/reactivex/SingleSource;Lio/reactivex/functions/Function;Ljava/lang/Object;)V", "")]
		public unsafe SingleOnErrorReturn (global::IO.Reactivex.ISingleSource source, global::IO.Reactivex.Functions.IFunction valueSupplier, global::Java.Lang.Object value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (source);
				__args [1] = new JValue (valueSupplier);
				__args [2] = new JValue (native_value);
				if (((object) this).GetType () != typeof (SingleOnErrorReturn)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/SingleSource;Lio/reactivex/functions/Function;Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/SingleSource;Lio/reactivex/functions/Function;Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/SingleSource;Lio/reactivex/functions/Function;Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function_Ljava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_SingleSource_Lio_reactivex_functions_Function_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_SingleObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.single']/class[@name='SingleOnErrorReturn']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleObserver&lt;? super T&gt;']]"
		[Register ("subscribeActual", "(Lio/reactivex/SingleObserver;)V", "")]
		protected override unsafe void SubscribeActual (global::IO.Reactivex.ISingleObserver observer)
		{
			if (id_subscribeActual_Lio_reactivex_SingleObserver_ == IntPtr.Zero)
				id_subscribeActual_Lio_reactivex_SingleObserver_ = JNIEnv.GetMethodID (class_ref, "subscribeActual", "(Lio/reactivex/SingleObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeActual_Lio_reactivex_SingleObserver_, __args);
			} finally {
			}
		}

	}
}
