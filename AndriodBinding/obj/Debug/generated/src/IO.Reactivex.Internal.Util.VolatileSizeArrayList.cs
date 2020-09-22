using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']"
	[global::Android.Runtime.Register ("io/reactivex/internal/util/VolatileSizeArrayList", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class VolatileSizeArrayList : global::Java.Util.Concurrent.Atomic.AtomicInteger, global::Java.Util.IList, global::Java.Util.IRandomAccess {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/util/VolatileSizeArrayList", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VolatileSizeArrayList); }
		}

		internal VolatileSizeArrayList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']/constructor[@name='VolatileSizeArrayList' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VolatileSizeArrayList ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VolatileSizeArrayList)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']/constructor[@name='VolatileSizeArrayList' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe VolatileSizeArrayList (int initialCapacity)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (initialCapacity);
				if (((object) this).GetType () != typeof (VolatileSizeArrayList)) {
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

		static IntPtr id_isEmpty;
		public unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "")]
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEmpty);
				} finally {
				}
			}
		}

		static IntPtr id_add_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']/method[@name='add' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='T']]"
		[Register ("add", "(ILjava/lang/Object;)V", "")]
		public unsafe void Add (int index, global::Java.Lang.Object element)
		{
			if (id_add_ILjava_lang_Object_ == IntPtr.Zero)
				id_add_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "add", "(ILjava/lang/Object;)V");
			IntPtr native_element = JNIEnv.ToLocalJniHandle (element);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (native_element);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_ILjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_element);
			}
		}

		static IntPtr id_add_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']/method[@name='add' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("add", "(Ljava/lang/Object;)Z", "")]
		public unsafe bool Add (global::Java.Lang.Object e)
		{
			if (id_add_Ljava_lang_Object_ == IntPtr.Zero)
				id_add_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/Object;)Z");
			IntPtr native_e = JNIEnv.ToLocalJniHandle (e);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_e);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_e);
			}
		}

		static IntPtr id_addAll_ILjava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']/method[@name='addAll' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.Collection&lt;? extends T&gt;']]"
		[Register ("addAll", "(ILjava/util/Collection;)Z", "")]
		public unsafe bool AddAll (int index, global::System.Collections.ICollection c)
		{
			if (id_addAll_ILjava_util_Collection_ == IntPtr.Zero)
				id_addAll_ILjava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "addAll", "(ILjava/util/Collection;)Z");
			IntPtr native_c = global::Android.Runtime.JavaCollection.ToLocalJniHandle (c);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (native_c);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_addAll_ILjava_util_Collection_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_c);
			}
		}

		static IntPtr id_addAll_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']/method[@name='addAll' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;? extends T&gt;']]"
		[Register ("addAll", "(Ljava/util/Collection;)Z", "")]
		public unsafe bool AddAll (global::System.Collections.ICollection c)
		{
			if (id_addAll_Ljava_util_Collection_ == IntPtr.Zero)
				id_addAll_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "addAll", "(Ljava/util/Collection;)Z");
			IntPtr native_c = global::Android.Runtime.JavaCollection.ToLocalJniHandle (c);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_c);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_addAll_Ljava_util_Collection_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_c);
			}
		}

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
			} finally {
			}
		}

		static IntPtr id_contains_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("contains", "(Ljava/lang/Object;)Z", "")]
		public unsafe bool Contains (global::Java.Lang.Object o)
		{
			if (id_contains_Ljava_lang_Object_ == IntPtr.Zero)
				id_contains_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "contains", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_containsAll_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']/method[@name='containsAll' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;?&gt;']]"
		[Register ("containsAll", "(Ljava/util/Collection;)Z", "")]
		public unsafe bool ContainsAll (global::System.Collections.ICollection c)
		{
			if (id_containsAll_Ljava_util_Collection_ == IntPtr.Zero)
				id_containsAll_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "containsAll", "(Ljava/util/Collection;)Z");
			IntPtr native_c = global::Android.Runtime.JavaCollection.ToLocalJniHandle (c);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_c);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_containsAll_Ljava_util_Collection_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_c);
			}
		}

		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object Get (int index)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_indexOf_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']/method[@name='indexOf' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("indexOf", "(Ljava/lang/Object;)I", "")]
		public unsafe int IndexOf (global::Java.Lang.Object o)
		{
			if (id_indexOf_Ljava_lang_Object_ == IntPtr.Zero)
				id_indexOf_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "indexOf", "(Ljava/lang/Object;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_indexOf_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_iterator;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']/method[@name='iterator' and count(parameter)=0]"
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

		static IntPtr id_lastIndexOf_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']/method[@name='lastIndexOf' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("lastIndexOf", "(Ljava/lang/Object;)I", "")]
		public unsafe int LastIndexOf (global::Java.Lang.Object o)
		{
			if (id_lastIndexOf_Ljava_lang_Object_ == IntPtr.Zero)
				id_lastIndexOf_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "lastIndexOf", "(Ljava/lang/Object;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_lastIndexOf_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_listIterator;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']/method[@name='listIterator' and count(parameter)=0]"
		[Register ("listIterator", "()Ljava/util/ListIterator;", "")]
		public unsafe global::Java.Util.IListIterator ListIterator ()
		{
			if (id_listIterator == IntPtr.Zero)
				id_listIterator = JNIEnv.GetMethodID (class_ref, "listIterator", "()Ljava/util/ListIterator;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.IListIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_listIterator), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_listIterator_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']/method[@name='listIterator' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("listIterator", "(I)Ljava/util/ListIterator;", "")]
		public unsafe global::Java.Util.IListIterator ListIterator (int index)
		{
			if (id_listIterator_I == IntPtr.Zero)
				id_listIterator_I = JNIEnv.GetMethodID (class_ref, "listIterator", "(I)Ljava/util/ListIterator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IListIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_listIterator_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_remove_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("remove", "(I)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object Remove (int index)
		{
			if (id_remove_I == IntPtr.Zero)
				id_remove_I = JNIEnv.GetMethodID (class_ref, "remove", "(I)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_remove_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_remove_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("remove", "(Ljava/lang/Object;)Z", "")]
		public unsafe bool Remove (global::Java.Lang.Object o)
		{
			if (id_remove_Ljava_lang_Object_ == IntPtr.Zero)
				id_remove_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_remove_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_removeAll_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']/method[@name='removeAll' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;?&gt;']]"
		[Register ("removeAll", "(Ljava/util/Collection;)Z", "")]
		public unsafe bool RemoveAll (global::System.Collections.ICollection c)
		{
			if (id_removeAll_Ljava_util_Collection_ == IntPtr.Zero)
				id_removeAll_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "removeAll", "(Ljava/util/Collection;)Z");
			IntPtr native_c = global::Android.Runtime.JavaCollection.ToLocalJniHandle (c);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_c);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeAll_Ljava_util_Collection_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_c);
			}
		}

		static IntPtr id_retainAll_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']/method[@name='retainAll' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;?&gt;']]"
		[Register ("retainAll", "(Ljava/util/Collection;)Z", "")]
		public unsafe bool RetainAll (global::System.Collections.ICollection c)
		{
			if (id_retainAll_Ljava_util_Collection_ == IntPtr.Zero)
				id_retainAll_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "retainAll", "(Ljava/util/Collection;)Z");
			IntPtr native_c = global::Android.Runtime.JavaCollection.ToLocalJniHandle (c);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_c);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_retainAll_Ljava_util_Collection_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_c);
			}
		}

		static IntPtr id_set_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='T']]"
		[Register ("set", "(ILjava/lang/Object;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object Set (int index, global::Java.Lang.Object element)
		{
			if (id_set_ILjava_lang_Object_ == IntPtr.Zero)
				id_set_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_element = JNIEnv.ToLocalJniHandle (element);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (native_element);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_set_ILjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_element);
			}
		}

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "")]
		public unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
			} finally {
			}
		}

		static IntPtr id_subList_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']/method[@name='subList' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("subList", "(II)Ljava/util/List;", "")]
		public unsafe global::System.Collections.IList SubList (int fromIndex, int toIndex)
		{
			if (id_subList_II == IntPtr.Zero)
				id_subList_II = JNIEnv.GetMethodID (class_ref, "subList", "(II)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (fromIndex);
				__args [1] = new JValue (toIndex);
				return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subList_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']/method[@name='toArray' and count(parameter)=0]"
		[Register ("toArray", "()[Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object[] ToArray ()
		{
			if (id_toArray == IntPtr.Zero)
				id_toArray = JNIEnv.GetMethodID (class_ref, "toArray", "()[Ljava/lang/Object;");
			try {
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toArray), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
			}
		}

		static IntPtr id_toArray_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='VolatileSizeArrayList']/method[@name='toArray' and count(parameter)=1 and parameter[1][@type='E[]']]"
		[Register ("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E"})]
		public unsafe global::Java.Lang.Object[] ToArray (global::Java.Lang.Object[] a)
		{
			if (id_toArray_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_toArray_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			IntPtr native_a = JNIEnv.NewArray (a);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_a);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toArray_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			} finally {
				if (a != null) {
					JNIEnv.CopyArray (native_a, a);
					JNIEnv.DeleteLocalRef (native_a);
				}
			}
		}

	}
}
