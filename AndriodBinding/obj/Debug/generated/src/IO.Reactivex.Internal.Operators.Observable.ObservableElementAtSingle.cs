using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Observable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableElementAtSingle']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/observable/ObservableElementAtSingle", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class ObservableElementAtSingle : global::IO.Reactivex.Single, global::IO.Reactivex.Internal.Fuseable.IFuseToObservable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/observable/ObservableElementAtSingle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObservableElementAtSingle); }
		}

		internal ObservableElementAtSingle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_ObservableSource_JLjava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableElementAtSingle']/constructor[@name='ObservableElementAtSingle' and count(parameter)=3 and parameter[1][@type='io.reactivex.ObservableSource&lt;T&gt;'] and parameter[2][@type='long'] and parameter[3][@type='T']]"
		[Register (".ctor", "(Lio/reactivex/ObservableSource;JLjava/lang/Object;)V", "")]
		public unsafe ObservableElementAtSingle (global::IO.Reactivex.IObservableSource source, long index, global::Java.Lang.Object defaultValue)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_defaultValue = JNIEnv.ToLocalJniHandle (defaultValue);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (source);
				__args [1] = new JValue (index);
				__args [2] = new JValue (native_defaultValue);
				if (((object) this).GetType () != typeof (ObservableElementAtSingle)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/ObservableSource;JLjava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/ObservableSource;JLjava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_ObservableSource_JLjava_lang_Object_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_ObservableSource_JLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/ObservableSource;JLjava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_ObservableSource_JLjava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_ObservableSource_JLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_defaultValue);
			}
		}

		static IntPtr id_fuseToObservable;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableElementAtSingle']/method[@name='fuseToObservable' and count(parameter)=0]"
		[Register ("fuseToObservable", "()Lio/reactivex/Observable;", "")]
		public unsafe global::IO.Reactivex.Observable FuseToObservable ()
		{
			if (id_fuseToObservable == IntPtr.Zero)
				id_fuseToObservable = JNIEnv.GetMethodID (class_ref, "fuseToObservable", "()Lio/reactivex/Observable;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fuseToObservable), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_SingleObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='ObservableElementAtSingle']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleObserver&lt;? super T&gt;']]"
		[Register ("subscribeActual", "(Lio/reactivex/SingleObserver;)V", "")]
		protected override unsafe void SubscribeActual (global::IO.Reactivex.ISingleObserver t)
		{
			if (id_subscribeActual_Lio_reactivex_SingleObserver_ == IntPtr.Zero)
				id_subscribeActual_Lio_reactivex_SingleObserver_ = JNIEnv.GetMethodID (class_ref, "subscribeActual", "(Lio/reactivex/SingleObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (t);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeActual_Lio_reactivex_SingleObserver_, __args);
			} finally {
			}
		}

	}
}
