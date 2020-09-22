using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Functions {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']"
	[global::Android.Runtime.Register ("io/reactivex/internal/functions/Functions", DoNotGenerateAcw=true)]
	public sealed partial class Functions : global::Java.Lang.Object {


		static IntPtr EMPTY_ACTION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/field[@name='EMPTY_ACTION']"
		[Register ("EMPTY_ACTION")]
		public static global::IO.Reactivex.Functions.IAction EmptyAction {
			get {
				if (EMPTY_ACTION_jfieldId == IntPtr.Zero)
					EMPTY_ACTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_ACTION", "Lio/reactivex/functions/Action;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMPTY_ACTION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IAction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_LONG_CONSUMER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/field[@name='EMPTY_LONG_CONSUMER']"
		[Register ("EMPTY_LONG_CONSUMER")]
		public static global::IO.Reactivex.Functions.ILongConsumer EmptyLongConsumer {
			get {
				if (EMPTY_LONG_CONSUMER_jfieldId == IntPtr.Zero)
					EMPTY_LONG_CONSUMER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_LONG_CONSUMER", "Lio/reactivex/functions/LongConsumer;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMPTY_LONG_CONSUMER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.ILongConsumer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_RUNNABLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/field[@name='EMPTY_RUNNABLE']"
		[Register ("EMPTY_RUNNABLE")]
		public static global::Java.Lang.IRunnable EmptyRunnable {
			get {
				if (EMPTY_RUNNABLE_jfieldId == IntPtr.Zero)
					EMPTY_RUNNABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_RUNNABLE", "Ljava/lang/Runnable;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMPTY_RUNNABLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ERROR_CONSUMER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/field[@name='ERROR_CONSUMER']"
		[Register ("ERROR_CONSUMER")]
		public static global::IO.Reactivex.Functions.IConsumer ErrorConsumer {
			get {
				if (ERROR_CONSUMER_jfieldId == IntPtr.Zero)
					ERROR_CONSUMER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_CONSUMER", "Lio/reactivex/functions/Consumer;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_CONSUMER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IConsumer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ON_ERROR_MISSING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/field[@name='ON_ERROR_MISSING']"
		[Register ("ON_ERROR_MISSING")]
		public static global::IO.Reactivex.Functions.IConsumer OnErrorMissing {
			get {
				if (ON_ERROR_MISSING_jfieldId == IntPtr.Zero)
					ON_ERROR_MISSING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ON_ERROR_MISSING", "Lio/reactivex/functions/Consumer;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ON_ERROR_MISSING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IConsumer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/functions/Functions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Functions); }
		}

		internal Functions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_actionConsumer_Lio_reactivex_functions_Action_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='actionConsumer' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Action']]"
		[Register ("actionConsumer", "(Lio/reactivex/functions/Action;)Lio/reactivex/functions/Consumer;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Functions.IConsumer ActionConsumer (global::IO.Reactivex.Functions.IAction action)
		{
			if (id_actionConsumer_Lio_reactivex_functions_Action_ == IntPtr.Zero)
				id_actionConsumer_Lio_reactivex_functions_Action_ = JNIEnv.GetStaticMethodID (class_ref, "actionConsumer", "(Lio/reactivex/functions/Action;)Lio/reactivex/functions/Consumer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (action);
				global::IO.Reactivex.Functions.IConsumer __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IConsumer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_actionConsumer_Lio_reactivex_functions_Action_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_alwaysFalse;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='alwaysFalse' and count(parameter)=0]"
		[Register ("alwaysFalse", "()Lio/reactivex/functions/Predicate;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Functions.IPredicate AlwaysFalse ()
		{
			if (id_alwaysFalse == IntPtr.Zero)
				id_alwaysFalse = JNIEnv.GetStaticMethodID (class_ref, "alwaysFalse", "()Lio/reactivex/functions/Predicate;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IPredicate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_alwaysFalse), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_alwaysTrue;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='alwaysTrue' and count(parameter)=0]"
		[Register ("alwaysTrue", "()Lio/reactivex/functions/Predicate;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Functions.IPredicate AlwaysTrue ()
		{
			if (id_alwaysTrue == IntPtr.Zero)
				id_alwaysTrue = JNIEnv.GetStaticMethodID (class_ref, "alwaysTrue", "()Lio/reactivex/functions/Predicate;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IPredicate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_alwaysTrue), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_boundedConsumer_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='boundedConsumer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("boundedConsumer", "(I)Lio/reactivex/functions/Consumer;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Functions.IConsumer BoundedConsumer (int bufferSize)
		{
			if (id_boundedConsumer_I == IntPtr.Zero)
				id_boundedConsumer_I = JNIEnv.GetStaticMethodID (class_ref, "boundedConsumer", "(I)Lio/reactivex/functions/Consumer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (bufferSize);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IConsumer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_boundedConsumer_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_castFunction_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='castFunction' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;U&gt;']]"
		[Register ("castFunction", "(Ljava/lang/Class;)Lio/reactivex/functions/Function;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U"})]
		public static unsafe global::IO.Reactivex.Functions.IFunction CastFunction (global::Java.Lang.Class target)
		{
			if (id_castFunction_Ljava_lang_Class_ == IntPtr.Zero)
				id_castFunction_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "castFunction", "(Ljava/lang/Class;)Lio/reactivex/functions/Function;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (target);
				global::IO.Reactivex.Functions.IFunction __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_castFunction_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createArrayList_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='createArrayList' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createArrayList", "(I)Ljava/util/concurrent/Callable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Util.Concurrent.ICallable CreateArrayList (int capacity)
		{
			if (id_createArrayList_I == IntPtr.Zero)
				id_createArrayList_I = JNIEnv.GetStaticMethodID (class_ref, "createArrayList", "(I)Ljava/util/concurrent/Callable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (capacity);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ICallable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createArrayList_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createHashSet;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='createHashSet' and count(parameter)=0]"
		[Register ("createHashSet", "()Ljava/util/concurrent/Callable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Util.Concurrent.ICallable CreateHashSet ()
		{
			if (id_createHashSet == IntPtr.Zero)
				id_createHashSet = JNIEnv.GetStaticMethodID (class_ref, "createHashSet", "()Ljava/util/concurrent/Callable;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ICallable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createHashSet), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_emptyConsumer;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='emptyConsumer' and count(parameter)=0]"
		[Register ("emptyConsumer", "()Lio/reactivex/functions/Consumer;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Functions.IConsumer EmptyConsumer ()
		{
			if (id_emptyConsumer == IntPtr.Zero)
				id_emptyConsumer = JNIEnv.GetStaticMethodID (class_ref, "emptyConsumer", "()Lio/reactivex/functions/Consumer;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IConsumer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_emptyConsumer), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_equalsWith_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='equalsWith' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("equalsWith", "(Ljava/lang/Object;)Lio/reactivex/functions/Predicate;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Functions.IPredicate EqualsWith (global::Java.Lang.Object value)
		{
			if (id_equalsWith_Ljava_lang_Object_ == IntPtr.Zero)
				id_equalsWith_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "equalsWith", "(Ljava/lang/Object;)Lio/reactivex/functions/Predicate;");
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				global::IO.Reactivex.Functions.IPredicate __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IPredicate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_equalsWith_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_futureAction_Ljava_util_concurrent_Future_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='futureAction' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Future&lt;?&gt;']]"
		[Register ("futureAction", "(Ljava/util/concurrent/Future;)Lio/reactivex/functions/Action;", "")]
		public static unsafe global::IO.Reactivex.Functions.IAction FutureAction (global::Java.Util.Concurrent.IFuture future)
		{
			if (id_futureAction_Ljava_util_concurrent_Future_ == IntPtr.Zero)
				id_futureAction_Ljava_util_concurrent_Future_ = JNIEnv.GetStaticMethodID (class_ref, "futureAction", "(Ljava/util/concurrent/Future;)Lio/reactivex/functions/Action;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (future);
				global::IO.Reactivex.Functions.IAction __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IAction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_futureAction_Ljava_util_concurrent_Future_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_identity;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='identity' and count(parameter)=0]"
		[Register ("identity", "()Lio/reactivex/functions/Function;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Functions.IFunction Identity ()
		{
			if (id_identity == IntPtr.Zero)
				id_identity = JNIEnv.GetStaticMethodID (class_ref, "identity", "()Lio/reactivex/functions/Function;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_identity), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_isInstanceOf_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='isInstanceOf' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;U&gt;']]"
		[Register ("isInstanceOf", "(Ljava/lang/Class;)Lio/reactivex/functions/Predicate;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U"})]
		public static unsafe global::IO.Reactivex.Functions.IPredicate IsInstanceOf (global::Java.Lang.Class clazz)
		{
			if (id_isInstanceOf_Ljava_lang_Class_ == IntPtr.Zero)
				id_isInstanceOf_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "isInstanceOf", "(Ljava/lang/Class;)Lio/reactivex/functions/Predicate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (clazz);
				global::IO.Reactivex.Functions.IPredicate __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IPredicate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_isInstanceOf_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_justCallable_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='justCallable' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("justCallable", "(Ljava/lang/Object;)Ljava/util/concurrent/Callable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Util.Concurrent.ICallable JustCallable (global::Java.Lang.Object value)
		{
			if (id_justCallable_Ljava_lang_Object_ == IntPtr.Zero)
				id_justCallable_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "justCallable", "(Ljava/lang/Object;)Ljava/util/concurrent/Callable;");
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				global::Java.Util.Concurrent.ICallable __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ICallable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_justCallable_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_justFunction_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='justFunction' and count(parameter)=1 and parameter[1][@type='U']]"
		[Register ("justFunction", "(Ljava/lang/Object;)Lio/reactivex/functions/Function;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U"})]
		public static unsafe global::IO.Reactivex.Functions.IFunction JustFunction (global::Java.Lang.Object value)
		{
			if (id_justFunction_Ljava_lang_Object_ == IntPtr.Zero)
				id_justFunction_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "justFunction", "(Ljava/lang/Object;)Lio/reactivex/functions/Function;");
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				global::IO.Reactivex.Functions.IFunction __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_justFunction_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_listSorter_Ljava_util_Comparator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='listSorter' and count(parameter)=1 and parameter[1][@type='java.util.Comparator&lt;? super T&gt;']]"
		[Register ("listSorter", "(Ljava/util/Comparator;)Lio/reactivex/functions/Function;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Functions.IFunction ListSorter (global::Java.Util.IComparator comparator)
		{
			if (id_listSorter_Ljava_util_Comparator_ == IntPtr.Zero)
				id_listSorter_Ljava_util_Comparator_ = JNIEnv.GetStaticMethodID (class_ref, "listSorter", "(Ljava/util/Comparator;)Lio/reactivex/functions/Function;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (comparator);
				global::IO.Reactivex.Functions.IFunction __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_listSorter_Ljava_util_Comparator_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_naturalComparator;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='naturalComparator' and count(parameter)=0]"
		[Register ("naturalComparator", "()Ljava/util/Comparator;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Util.IComparator NaturalComparator ()
		{
			if (id_naturalComparator == IntPtr.Zero)
				id_naturalComparator = JNIEnv.GetStaticMethodID (class_ref, "naturalComparator", "()Ljava/util/Comparator;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_naturalComparator), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_naturalOrder;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='naturalOrder' and count(parameter)=0]"
		[Register ("naturalOrder", "()Ljava/util/Comparator;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Util.IComparator NaturalOrder ()
		{
			if (id_naturalOrder == IntPtr.Zero)
				id_naturalOrder = JNIEnv.GetStaticMethodID (class_ref, "naturalOrder", "()Ljava/util/Comparator;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_naturalOrder), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_notificationOnComplete_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='notificationOnComplete' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super io.reactivex.Notification&lt;T&gt;&gt;']]"
		[Register ("notificationOnComplete", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/functions/Action;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Functions.IAction NotificationOnComplete (global::IO.Reactivex.Functions.IConsumer onNotification)
		{
			if (id_notificationOnComplete_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_notificationOnComplete_Lio_reactivex_functions_Consumer_ = JNIEnv.GetStaticMethodID (class_ref, "notificationOnComplete", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/functions/Action;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onNotification);
				global::IO.Reactivex.Functions.IAction __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IAction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_notificationOnComplete_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_notificationOnError_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='notificationOnError' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super io.reactivex.Notification&lt;T&gt;&gt;']]"
		[Register ("notificationOnError", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/functions/Consumer;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Functions.IConsumer NotificationOnError (global::IO.Reactivex.Functions.IConsumer onNotification)
		{
			if (id_notificationOnError_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_notificationOnError_Lio_reactivex_functions_Consumer_ = JNIEnv.GetStaticMethodID (class_ref, "notificationOnError", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/functions/Consumer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onNotification);
				global::IO.Reactivex.Functions.IConsumer __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IConsumer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_notificationOnError_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_notificationOnNext_Lio_reactivex_functions_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='notificationOnNext' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Consumer&lt;? super io.reactivex.Notification&lt;T&gt;&gt;']]"
		[Register ("notificationOnNext", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/functions/Consumer;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Functions.IConsumer NotificationOnNext (global::IO.Reactivex.Functions.IConsumer onNotification)
		{
			if (id_notificationOnNext_Lio_reactivex_functions_Consumer_ == IntPtr.Zero)
				id_notificationOnNext_Lio_reactivex_functions_Consumer_ = JNIEnv.GetStaticMethodID (class_ref, "notificationOnNext", "(Lio/reactivex/functions/Consumer;)Lio/reactivex/functions/Consumer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onNotification);
				global::IO.Reactivex.Functions.IConsumer __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IConsumer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_notificationOnNext_Lio_reactivex_functions_Consumer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_nullSupplier;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='nullSupplier' and count(parameter)=0]"
		[Register ("nullSupplier", "()Ljava/util/concurrent/Callable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Util.Concurrent.ICallable NullSupplier ()
		{
			if (id_nullSupplier == IntPtr.Zero)
				id_nullSupplier = JNIEnv.GetStaticMethodID (class_ref, "nullSupplier", "()Ljava/util/concurrent/Callable;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ICallable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_nullSupplier), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_predicateReverseFor_Lio_reactivex_functions_BooleanSupplier_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='predicateReverseFor' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.BooleanSupplier']]"
		[Register ("predicateReverseFor", "(Lio/reactivex/functions/BooleanSupplier;)Lio/reactivex/functions/Predicate;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Functions.IPredicate PredicateReverseFor (global::IO.Reactivex.Functions.IBooleanSupplier supplier)
		{
			if (id_predicateReverseFor_Lio_reactivex_functions_BooleanSupplier_ == IntPtr.Zero)
				id_predicateReverseFor_Lio_reactivex_functions_BooleanSupplier_ = JNIEnv.GetStaticMethodID (class_ref, "predicateReverseFor", "(Lio/reactivex/functions/BooleanSupplier;)Lio/reactivex/functions/Predicate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (supplier);
				global::IO.Reactivex.Functions.IPredicate __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IPredicate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_predicateReverseFor_Lio_reactivex_functions_BooleanSupplier_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_timestampWith_Ljava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='timestampWith' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.TimeUnit'] and parameter[2][@type='io.reactivex.Scheduler']]"
		[Register ("timestampWith", "(Ljava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/functions/Function;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Functions.IFunction TimestampWith (global::Java.Util.Concurrent.TimeUnit unit, global::IO.Reactivex.Scheduler scheduler)
		{
			if (id_timestampWith_Ljava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ == IntPtr.Zero)
				id_timestampWith_Ljava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_ = JNIEnv.GetStaticMethodID (class_ref, "timestampWith", "(Ljava/util/concurrent/TimeUnit;Lio/reactivex/Scheduler;)Lio/reactivex/functions/Function;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (unit);
				__args [1] = new JValue (scheduler);
				global::IO.Reactivex.Functions.IFunction __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_timestampWith_Ljava_util_concurrent_TimeUnit_Lio_reactivex_Scheduler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toFunction_Lio_reactivex_functions_BiFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='toFunction' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.BiFunction&lt;? super T1, ? super T2, ? extends R&gt;']]"
		[Register ("toFunction", "(Lio/reactivex/functions/BiFunction;)Lio/reactivex/functions/Function;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "R"})]
		public static unsafe global::IO.Reactivex.Functions.IFunction ToFunction (global::IO.Reactivex.Functions.IBiFunction f)
		{
			if (id_toFunction_Lio_reactivex_functions_BiFunction_ == IntPtr.Zero)
				id_toFunction_Lio_reactivex_functions_BiFunction_ = JNIEnv.GetStaticMethodID (class_ref, "toFunction", "(Lio/reactivex/functions/BiFunction;)Lio/reactivex/functions/Function;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (f);
				global::IO.Reactivex.Functions.IFunction __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toFunction_Lio_reactivex_functions_BiFunction_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toFunction_Lio_reactivex_functions_Function3_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='toFunction' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function3&lt;T1, T2, T3, R&gt;']]"
		[Register ("toFunction", "(Lio/reactivex/functions/Function3;)Lio/reactivex/functions/Function;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "R"})]
		public static unsafe global::IO.Reactivex.Functions.IFunction ToFunction (global::IO.Reactivex.Functions.IFunction3 f)
		{
			if (id_toFunction_Lio_reactivex_functions_Function3_ == IntPtr.Zero)
				id_toFunction_Lio_reactivex_functions_Function3_ = JNIEnv.GetStaticMethodID (class_ref, "toFunction", "(Lio/reactivex/functions/Function3;)Lio/reactivex/functions/Function;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (f);
				global::IO.Reactivex.Functions.IFunction __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toFunction_Lio_reactivex_functions_Function3_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toFunction_Lio_reactivex_functions_Function4_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='toFunction' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function4&lt;T1, T2, T3, T4, R&gt;']]"
		[Register ("toFunction", "(Lio/reactivex/functions/Function4;)Lio/reactivex/functions/Function;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "R"})]
		public static unsafe global::IO.Reactivex.Functions.IFunction ToFunction (global::IO.Reactivex.Functions.IFunction4 f)
		{
			if (id_toFunction_Lio_reactivex_functions_Function4_ == IntPtr.Zero)
				id_toFunction_Lio_reactivex_functions_Function4_ = JNIEnv.GetStaticMethodID (class_ref, "toFunction", "(Lio/reactivex/functions/Function4;)Lio/reactivex/functions/Function;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (f);
				global::IO.Reactivex.Functions.IFunction __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toFunction_Lio_reactivex_functions_Function4_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toFunction_Lio_reactivex_functions_Function5_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='toFunction' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function5&lt;T1, T2, T3, T4, T5, R&gt;']]"
		[Register ("toFunction", "(Lio/reactivex/functions/Function5;)Lio/reactivex/functions/Function;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "T5", "R"})]
		public static unsafe global::IO.Reactivex.Functions.IFunction ToFunction (global::IO.Reactivex.Functions.IFunction5 f)
		{
			if (id_toFunction_Lio_reactivex_functions_Function5_ == IntPtr.Zero)
				id_toFunction_Lio_reactivex_functions_Function5_ = JNIEnv.GetStaticMethodID (class_ref, "toFunction", "(Lio/reactivex/functions/Function5;)Lio/reactivex/functions/Function;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (f);
				global::IO.Reactivex.Functions.IFunction __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toFunction_Lio_reactivex_functions_Function5_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toFunction_Lio_reactivex_functions_Function6_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='toFunction' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function6&lt;T1, T2, T3, T4, T5, T6, R&gt;']]"
		[Register ("toFunction", "(Lio/reactivex/functions/Function6;)Lio/reactivex/functions/Function;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "T5", "T6", "R"})]
		public static unsafe global::IO.Reactivex.Functions.IFunction ToFunction (global::IO.Reactivex.Functions.IFunction6 f)
		{
			if (id_toFunction_Lio_reactivex_functions_Function6_ == IntPtr.Zero)
				id_toFunction_Lio_reactivex_functions_Function6_ = JNIEnv.GetStaticMethodID (class_ref, "toFunction", "(Lio/reactivex/functions/Function6;)Lio/reactivex/functions/Function;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (f);
				global::IO.Reactivex.Functions.IFunction __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toFunction_Lio_reactivex_functions_Function6_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toFunction_Lio_reactivex_functions_Function7_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='toFunction' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function7&lt;T1, T2, T3, T4, T5, T6, T7, R&gt;']]"
		[Register ("toFunction", "(Lio/reactivex/functions/Function7;)Lio/reactivex/functions/Function;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "T5", "T6", "T7", "R"})]
		public static unsafe global::IO.Reactivex.Functions.IFunction ToFunction (global::IO.Reactivex.Functions.IFunction7 f)
		{
			if (id_toFunction_Lio_reactivex_functions_Function7_ == IntPtr.Zero)
				id_toFunction_Lio_reactivex_functions_Function7_ = JNIEnv.GetStaticMethodID (class_ref, "toFunction", "(Lio/reactivex/functions/Function7;)Lio/reactivex/functions/Function;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (f);
				global::IO.Reactivex.Functions.IFunction __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toFunction_Lio_reactivex_functions_Function7_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toFunction_Lio_reactivex_functions_Function8_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='toFunction' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function8&lt;T1, T2, T3, T4, T5, T6, T7, T8, R&gt;']]"
		[Register ("toFunction", "(Lio/reactivex/functions/Function8;)Lio/reactivex/functions/Function;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "T5", "T6", "T7", "T8", "R"})]
		public static unsafe global::IO.Reactivex.Functions.IFunction ToFunction (global::IO.Reactivex.Functions.IFunction8 f)
		{
			if (id_toFunction_Lio_reactivex_functions_Function8_ == IntPtr.Zero)
				id_toFunction_Lio_reactivex_functions_Function8_ = JNIEnv.GetStaticMethodID (class_ref, "toFunction", "(Lio/reactivex/functions/Function8;)Lio/reactivex/functions/Function;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (f);
				global::IO.Reactivex.Functions.IFunction __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toFunction_Lio_reactivex_functions_Function8_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toFunction_Lio_reactivex_functions_Function9_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='toFunction' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function9&lt;T1, T2, T3, T4, T5, T6, T7, T8, T9, R&gt;']]"
		[Register ("toFunction", "(Lio/reactivex/functions/Function9;)Lio/reactivex/functions/Function;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3", "T4", "T5", "T6", "T7", "T8", "T9", "R"})]
		public static unsafe global::IO.Reactivex.Functions.IFunction ToFunction (global::IO.Reactivex.Functions.IFunction9 f)
		{
			if (id_toFunction_Lio_reactivex_functions_Function9_ == IntPtr.Zero)
				id_toFunction_Lio_reactivex_functions_Function9_ = JNIEnv.GetStaticMethodID (class_ref, "toFunction", "(Lio/reactivex/functions/Function9;)Lio/reactivex/functions/Function;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (f);
				global::IO.Reactivex.Functions.IFunction __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IFunction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toFunction_Lio_reactivex_functions_Function9_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toMapKeySelector_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='toMapKeySelector' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends K&gt;']]"
		[Register ("toMapKeySelector", "(Lio/reactivex/functions/Function;)Lio/reactivex/functions/BiConsumer;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "K"})]
		public static unsafe global::IO.Reactivex.Functions.IBiConsumer ToMapKeySelector (global::IO.Reactivex.Functions.IFunction keySelector)
		{
			if (id_toMapKeySelector_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_toMapKeySelector_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "toMapKeySelector", "(Lio/reactivex/functions/Function;)Lio/reactivex/functions/BiConsumer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (keySelector);
				global::IO.Reactivex.Functions.IBiConsumer __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IBiConsumer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toMapKeySelector_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toMapKeyValueSelector_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='toMapKeyValueSelector' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends K&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super T, ? extends V&gt;']]"
		[Register ("toMapKeyValueSelector", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;)Lio/reactivex/functions/BiConsumer;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "K", "V"})]
		public static unsafe global::IO.Reactivex.Functions.IBiConsumer ToMapKeyValueSelector (global::IO.Reactivex.Functions.IFunction keySelector, global::IO.Reactivex.Functions.IFunction valueSelector)
		{
			if (id_toMapKeyValueSelector_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_toMapKeyValueSelector_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "toMapKeyValueSelector", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;)Lio/reactivex/functions/BiConsumer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (keySelector);
				__args [1] = new JValue (valueSelector);
				global::IO.Reactivex.Functions.IBiConsumer __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IBiConsumer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toMapKeyValueSelector_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toMultimapKeyValueSelector_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.functions']/class[@name='Functions']/method[@name='toMultimapKeyValueSelector' and count(parameter)=3 and parameter[1][@type='io.reactivex.functions.Function&lt;? super T, ? extends K&gt;'] and parameter[2][@type='io.reactivex.functions.Function&lt;? super T, ? extends V&gt;'] and parameter[3][@type='io.reactivex.functions.Function&lt;? super K, ? extends java.util.Collection&lt;? super V&gt;&gt;']]"
		[Register ("toMultimapKeyValueSelector", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;)Lio/reactivex/functions/BiConsumer;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "K", "V"})]
		public static unsafe global::IO.Reactivex.Functions.IBiConsumer ToMultimapKeyValueSelector (global::IO.Reactivex.Functions.IFunction keySelector, global::IO.Reactivex.Functions.IFunction valueSelector, global::IO.Reactivex.Functions.IFunction collectionFactory)
		{
			if (id_toMultimapKeyValueSelector_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_ == IntPtr.Zero)
				id_toMultimapKeyValueSelector_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_ = JNIEnv.GetStaticMethodID (class_ref, "toMultimapKeyValueSelector", "(Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;Lio/reactivex/functions/Function;)Lio/reactivex/functions/BiConsumer;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (keySelector);
				__args [1] = new JValue (valueSelector);
				__args [2] = new JValue (collectionFactory);
				global::IO.Reactivex.Functions.IBiConsumer __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Functions.IBiConsumer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toMultimapKeyValueSelector_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_Lio_reactivex_functions_Function_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
