using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Repository.Local.Database.Room {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='DatabaseManager_Room']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/repository/local/database/room/DatabaseManager_Room", DoNotGenerateAcw=true)]
	public partial class DatabaseManager_Room : global::Java.Lang.Object, global::Android.OS.Handler.ICallback {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='DatabaseManager_Room']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "DatabaseManager";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='DatabaseManager_Room']/field[@name='mContext']"
		[Register ("mContext")]
		public global::Android.Content.Context MContext {
			get {
				const string __id = "mContext.Landroid/content/Context;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mContext.Landroid/content/Context;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='DatabaseManager_Room']/field[@name='mWorkHandler']"
		[Register ("mWorkHandler")]
		public global::Android.OS.Handler MWorkHandler {
			get {
				const string __id = "mWorkHandler.Landroid/os/Handler;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mWorkHandler.Landroid/os/Handler;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='DatabaseManager_Room']/field[@name='time']"
		[Register ("time")]
		public const int Time = (int) 3600;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='DatabaseManager_Room.SingletonHolder']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/repository/local/database/room/DatabaseManager_Room$SingletonHolder", DoNotGenerateAcw=true)]
		public partial class SingletonHolder : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='DatabaseManager_Room.SingletonHolder']/field[@name='INSTANCE']"
			[Register ("INSTANCE")]
			public static global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.DatabaseManager_Room Instance {
				get {
					const string __id = "INSTANCE.Lcom/vivalnk/sdk/repository/local/database/room/DatabaseManager_Room;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.DatabaseManager_Room> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/repository/local/database/room/DatabaseManager_Room$SingletonHolder", typeof (SingletonHolder));
			internal static IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected SingletonHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='DatabaseManager_Room.SingletonHolder']/constructor[@name='DatabaseManager_Room.SingletonHolder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SingletonHolder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/repository/local/database/room/DatabaseManager_Room", typeof (DatabaseManager_Room));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected DatabaseManager_Room (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='DatabaseManager_Room']/constructor[@name='DatabaseManager_Room' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DatabaseManager_Room ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public static unsafe global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.DatabaseManager_Room Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='DatabaseManager_Room']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/vivalnk/sdk/repository/local/database/room/DatabaseManager_Room;", "")]
			get {
				const string __id = "getInstance.()Lcom/vivalnk/sdk/repository/local/database/room/DatabaseManager_Room;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.DatabaseManager_Room> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVitalDataDAO;
#pragma warning disable 0169
		static Delegate GetGetVitalDataDAOHandler ()
		{
			if (cb_getVitalDataDAO == null)
				cb_getVitalDataDAO = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetVitalDataDAO);
			return cb_getVitalDataDAO;
		}

		static IntPtr n_GetVitalDataDAO (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.DatabaseManager_Room> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VitalDataDAO);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAO VitalDataDAO {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='DatabaseManager_Room']/method[@name='getVitalDataDAO' and count(parameter)=0]"
			[Register ("getVitalDataDAO", "()Lcom/vivalnk/sdk/repository/local/database/room/IRoomDataDAO;", "GetGetVitalDataDAOHandler")]
			get {
				const string __id = "getVitalDataDAO.()Lcom/vivalnk/sdk/repository/local/database/room/IRoomDataDAO;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAO> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVitalDeviceDAO;
#pragma warning disable 0169
		static Delegate GetGetVitalDeviceDAOHandler ()
		{
			if (cb_getVitalDeviceDAO == null)
				cb_getVitalDeviceDAO = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetVitalDeviceDAO);
			return cb_getVitalDeviceDAO;
		}

		static IntPtr n_GetVitalDeviceDAO (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.DatabaseManager_Room> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VitalDeviceDAO);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDeviceDAO VitalDeviceDAO {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='DatabaseManager_Room']/method[@name='getVitalDeviceDAO' and count(parameter)=0]"
			[Register ("getVitalDeviceDAO", "()Lcom/vivalnk/sdk/repository/local/database/room/IRoomDeviceDAO;", "GetGetVitalDeviceDAOHandler")]
			get {
				const string __id = "getVitalDeviceDAO.()Lcom/vivalnk/sdk/repository/local/database/room/IRoomDeviceDAO;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDeviceDAO> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_handleMessage_Landroid_os_Message_;
#pragma warning disable 0169
		static Delegate GetHandleMessage_Landroid_os_Message_Handler ()
		{
			if (cb_handleMessage_Landroid_os_Message_ == null)
				cb_handleMessage_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HandleMessage_Landroid_os_Message_);
			return cb_handleMessage_Landroid_os_Message_;
		}

		static bool n_HandleMessage_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.DatabaseManager_Room> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleMessage (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='DatabaseManager_Room']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("handleMessage", "(Landroid/os/Message;)Z", "GetHandleMessage_Landroid_os_Message_Handler")]
		public virtual unsafe bool HandleMessage (global::Android.OS.Message p0)
		{
			const string __id = "handleMessage.(Landroid/os/Message;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_init_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Handler ()
		{
			if (cb_init_Landroid_content_Context_ == null)
				cb_init_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Init_Landroid_content_Context_);
			return cb_init_Landroid_content_Context_;
		}

		static void n_Init_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.DatabaseManager_Room> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='DatabaseManager_Room']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "GetInit_Landroid_content_Context_Handler")]
		public virtual unsafe void Init (global::Android.Content.Context p0)
		{
			const string __id = "init.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
