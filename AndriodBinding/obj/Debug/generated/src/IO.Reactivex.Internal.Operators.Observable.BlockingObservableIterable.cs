using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Observable {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='BlockingObservableIterable']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/observable/BlockingObservableIterable", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class BlockingObservableIterable : global::Java.Lang.Object, global::Java.Lang.IIterable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/observable/BlockingObservableIterable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BlockingObservableIterable); }
		}

		internal BlockingObservableIterable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_ObservableSource_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='BlockingObservableIterable']/constructor[@name='BlockingObservableIterable' and count(parameter)=2 and parameter[1][@type='io.reactivex.ObservableSource&lt;? extends T&gt;'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lio/reactivex/ObservableSource;I)V", "")]
		public unsafe BlockingObservableIterable (global::IO.Reactivex.IObservableSource source, int bufferSize)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (source);
				__args [1] = new JValue (bufferSize);
				if (((object) this).GetType () != typeof (BlockingObservableIterable)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/ObservableSource;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/ObservableSource;I)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_ObservableSource_I == IntPtr.Zero)
					id_ctor_Lio_reactivex_ObservableSource_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/ObservableSource;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_ObservableSource_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_ObservableSource_I, __args);
			} finally {
			}
		}

		static IntPtr id_iterator;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.observable']/class[@name='BlockingObservableIterable']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "")]
		public unsafe global::Java.Util.IIterator Iterator ()
		{
			if (id_iterator == IntPtr.Zero)
				id_iterator = JNIEnv.GetMethodID (class_ref, "iterator", "()Ljava/util/Iterator;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
