using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='AppendOnlyLinkedArrayList']"
	[global::Android.Runtime.Register ("io/reactivex/internal/util/AppendOnlyLinkedArrayList", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class AppendOnlyLinkedArrayList : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex.internal.util']/interface[@name='AppendOnlyLinkedArrayList.NonThrowingPredicate']"
		[Register ("io/reactivex/internal/util/AppendOnlyLinkedArrayList$NonThrowingPredicate", "", "IO.Reactivex.Internal.Util.AppendOnlyLinkedArrayList/INonThrowingPredicateInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial interface INonThrowingPredicate : global::IO.Reactivex.Functions.IPredicate {

			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/interface[@name='AppendOnlyLinkedArrayList.NonThrowingPredicate']/method[@name='test' and count(parameter)=1 and parameter[1][@type='T']]"
			[Register ("test", "(Ljava/lang/Object;)Z", "GetTest_Ljava_lang_Object_Handler:IO.Reactivex.Internal.Util.AppendOnlyLinkedArrayList/INonThrowingPredicateInvoker, AndriodBinding")]
			bool Test (global::Java.Lang.Object p0);

		}

		[global::Android.Runtime.Register ("io/reactivex/internal/util/AppendOnlyLinkedArrayList$NonThrowingPredicate", DoNotGenerateAcw=true)]
		internal partial class INonThrowingPredicateInvoker : global::Java.Lang.Object, INonThrowingPredicate {

			static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/internal/util/AppendOnlyLinkedArrayList$NonThrowingPredicate");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (INonThrowingPredicateInvoker); }
			}

			IntPtr class_ref;

			public static INonThrowingPredicate GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<INonThrowingPredicate> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.internal.util.AppendOnlyLinkedArrayList.NonThrowingPredicate"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public INonThrowingPredicateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_test_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetTest_Ljava_lang_Object_Handler ()
			{
				if (cb_test_Ljava_lang_Object_ == null)
					cb_test_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Test_Ljava_lang_Object_);
				return cb_test_Ljava_lang_Object_;
			}

			static bool n_Test_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Util.AppendOnlyLinkedArrayList.INonThrowingPredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Test (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_test_Ljava_lang_Object_;
			public unsafe bool Test (global::Java.Lang.Object p0)
			{
				if (id_test_Ljava_lang_Object_ == IntPtr.Zero)
					id_test_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "test", "(Ljava/lang/Object;)Z");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_test_Ljava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/util/AppendOnlyLinkedArrayList", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppendOnlyLinkedArrayList); }
		}

		protected AppendOnlyLinkedArrayList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='AppendOnlyLinkedArrayList']/constructor[@name='AppendOnlyLinkedArrayList' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe AppendOnlyLinkedArrayList (int capacity)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (capacity);
				if (((object) this).GetType () != typeof (AppendOnlyLinkedArrayList)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_accept_Lio_reactivex_Observer_;
#pragma warning disable 0169
		static Delegate GetAccept_Lio_reactivex_Observer_Handler ()
		{
			if (cb_accept_Lio_reactivex_Observer_ == null)
				cb_accept_Lio_reactivex_Observer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Accept_Lio_reactivex_Observer_);
			return cb_accept_Lio_reactivex_Observer_;
		}

		static bool n_Accept_Lio_reactivex_Observer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Util.AppendOnlyLinkedArrayList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var observer = (global::IO.Reactivex.IObserver)global::Java.Lang.Object.GetObject<global::IO.Reactivex.IObserver> (native_observer, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Accept (observer);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_accept_Lio_reactivex_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='AppendOnlyLinkedArrayList']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='io.reactivex.Observer&lt;? super U&gt;']]"
		[Register ("accept", "(Lio/reactivex/Observer;)Z", "GetAccept_Lio_reactivex_Observer_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public virtual unsafe bool Accept (global::IO.Reactivex.IObserver observer)
		{
			if (id_accept_Lio_reactivex_Observer_ == IntPtr.Zero)
				id_accept_Lio_reactivex_Observer_ = JNIEnv.GetMethodID (class_ref, "accept", "(Lio/reactivex/Observer;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_accept_Lio_reactivex_Observer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "accept", "(Lio/reactivex/Observer;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_add_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_Object_Handler ()
		{
			if (cb_add_Ljava_lang_Object_ == null)
				cb_add_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Add_Ljava_lang_Object_);
			return cb_add_Ljava_lang_Object_;
		}

		static void n_Add_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Util.AppendOnlyLinkedArrayList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Add (value);
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='AppendOnlyLinkedArrayList']/method[@name='add' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("add", "(Ljava/lang/Object;)V", "GetAdd_Ljava_lang_Object_Handler")]
		public virtual unsafe void Add (global::Java.Lang.Object value)
		{
			if (id_add_Ljava_lang_Object_ == IntPtr.Zero)
				id_add_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/Object;)V");
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_forEachWhile_Lio_reactivex_internal_util_AppendOnlyLinkedArrayList_NonThrowingPredicate_;
#pragma warning disable 0169
		static Delegate GetForEachWhile_Lio_reactivex_internal_util_AppendOnlyLinkedArrayList_NonThrowingPredicate_Handler ()
		{
			if (cb_forEachWhile_Lio_reactivex_internal_util_AppendOnlyLinkedArrayList_NonThrowingPredicate_ == null)
				cb_forEachWhile_Lio_reactivex_internal_util_AppendOnlyLinkedArrayList_NonThrowingPredicate_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ForEachWhile_Lio_reactivex_internal_util_AppendOnlyLinkedArrayList_NonThrowingPredicate_);
			return cb_forEachWhile_Lio_reactivex_internal_util_AppendOnlyLinkedArrayList_NonThrowingPredicate_;
		}

		static void n_ForEachWhile_Lio_reactivex_internal_util_AppendOnlyLinkedArrayList_NonThrowingPredicate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_consumer)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Util.AppendOnlyLinkedArrayList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var consumer = (global::IO.Reactivex.Internal.Util.AppendOnlyLinkedArrayList.INonThrowingPredicate)global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Util.AppendOnlyLinkedArrayList.INonThrowingPredicate> (native_consumer, JniHandleOwnership.DoNotTransfer);
			__this.ForEachWhile (consumer);
		}
#pragma warning restore 0169

		static IntPtr id_forEachWhile_Lio_reactivex_internal_util_AppendOnlyLinkedArrayList_NonThrowingPredicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='AppendOnlyLinkedArrayList']/method[@name='forEachWhile' and count(parameter)=1 and parameter[1][@type='io.reactivex.internal.util.AppendOnlyLinkedArrayList.NonThrowingPredicate&lt;? super T&gt;']]"
		[Register ("forEachWhile", "(Lio/reactivex/internal/util/AppendOnlyLinkedArrayList$NonThrowingPredicate;)V", "GetForEachWhile_Lio_reactivex_internal_util_AppendOnlyLinkedArrayList_NonThrowingPredicate_Handler")]
		public virtual unsafe void ForEachWhile (global::IO.Reactivex.Internal.Util.AppendOnlyLinkedArrayList.INonThrowingPredicate consumer)
		{
			if (id_forEachWhile_Lio_reactivex_internal_util_AppendOnlyLinkedArrayList_NonThrowingPredicate_ == IntPtr.Zero)
				id_forEachWhile_Lio_reactivex_internal_util_AppendOnlyLinkedArrayList_NonThrowingPredicate_ = JNIEnv.GetMethodID (class_ref, "forEachWhile", "(Lio/reactivex/internal/util/AppendOnlyLinkedArrayList$NonThrowingPredicate;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (consumer);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_forEachWhile_Lio_reactivex_internal_util_AppendOnlyLinkedArrayList_NonThrowingPredicate_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "forEachWhile", "(Lio/reactivex/internal/util/AppendOnlyLinkedArrayList$NonThrowingPredicate;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_forEachWhile_Ljava_lang_Object_Lio_reactivex_functions_BiPredicate_;
#pragma warning disable 0169
		static Delegate GetForEachWhile_Ljava_lang_Object_Lio_reactivex_functions_BiPredicate_Handler ()
		{
			if (cb_forEachWhile_Ljava_lang_Object_Lio_reactivex_functions_BiPredicate_ == null)
				cb_forEachWhile_Ljava_lang_Object_Lio_reactivex_functions_BiPredicate_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_ForEachWhile_Ljava_lang_Object_Lio_reactivex_functions_BiPredicate_);
			return cb_forEachWhile_Ljava_lang_Object_Lio_reactivex_functions_BiPredicate_;
		}

		static void n_ForEachWhile_Ljava_lang_Object_Lio_reactivex_functions_BiPredicate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_state, IntPtr native_consumer)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Util.AppendOnlyLinkedArrayList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var state = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_state, JniHandleOwnership.DoNotTransfer);
			var consumer = (global::IO.Reactivex.Functions.IBiPredicate)global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IBiPredicate> (native_consumer, JniHandleOwnership.DoNotTransfer);
			__this.ForEachWhile (state, consumer);
		}
#pragma warning restore 0169

		static IntPtr id_forEachWhile_Ljava_lang_Object_Lio_reactivex_functions_BiPredicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='AppendOnlyLinkedArrayList']/method[@name='forEachWhile' and count(parameter)=2 and parameter[1][@type='S'] and parameter[2][@type='io.reactivex.functions.BiPredicate&lt;? super S, ? super T&gt;']]"
		[Register ("forEachWhile", "(Ljava/lang/Object;Lio/reactivex/functions/BiPredicate;)V", "GetForEachWhile_Ljava_lang_Object_Lio_reactivex_functions_BiPredicate_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S"})]
		public virtual unsafe void ForEachWhile (global::Java.Lang.Object state, global::IO.Reactivex.Functions.IBiPredicate consumer)
		{
			if (id_forEachWhile_Ljava_lang_Object_Lio_reactivex_functions_BiPredicate_ == IntPtr.Zero)
				id_forEachWhile_Ljava_lang_Object_Lio_reactivex_functions_BiPredicate_ = JNIEnv.GetMethodID (class_ref, "forEachWhile", "(Ljava/lang/Object;Lio/reactivex/functions/BiPredicate;)V");
			IntPtr native_state = JNIEnv.ToLocalJniHandle (state);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_state);
				__args [1] = new JValue (consumer);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_forEachWhile_Ljava_lang_Object_Lio_reactivex_functions_BiPredicate_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "forEachWhile", "(Ljava/lang/Object;Lio/reactivex/functions/BiPredicate;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_state);
			}
		}

		static Delegate cb_setFirst_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetFirst_Ljava_lang_Object_Handler ()
		{
			if (cb_setFirst_Ljava_lang_Object_ == null)
				cb_setFirst_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFirst_Ljava_lang_Object_);
			return cb_setFirst_Ljava_lang_Object_;
		}

		static void n_SetFirst_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Util.AppendOnlyLinkedArrayList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SetFirst (value);
		}
#pragma warning restore 0169

		static IntPtr id_setFirst_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='AppendOnlyLinkedArrayList']/method[@name='setFirst' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("setFirst", "(Ljava/lang/Object;)V", "GetSetFirst_Ljava_lang_Object_Handler")]
		public virtual unsafe void SetFirst (global::Java.Lang.Object value)
		{
			if (id_setFirst_Ljava_lang_Object_ == IntPtr.Zero)
				id_setFirst_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setFirst", "(Ljava/lang/Object;)V");
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFirst_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFirst", "(Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
