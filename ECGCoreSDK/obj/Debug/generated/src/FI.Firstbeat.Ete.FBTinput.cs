using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FI.Firstbeat.Ete {

	// Metadata.xml XPath class reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTinput']"
	[global::Android.Runtime.Register ("fi/firstbeat/ete/FBTinput", DoNotGenerateAcw=true)]
	public partial class FBTinput : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTinput']/field[@name='Fs']"
		[Register ("Fs")]
		public int Fs {
			get {
				const string __id = "Fs.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "Fs.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTinput']/field[@name='acc']"
		[Register ("acc")]
		public IList<int> Acc {
			get {
				const string __id = "acc.[I";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "acc.[I";

				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTinput']/field[@name='altiSource']"
		[Register ("altiSource")]
		public int AltiSource {
			get {
				const string __id = "altiSource.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "altiSource.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTinput']/field[@name='altitude']"
		[Register ("altitude")]
		public int Altitude {
			get {
				const string __id = "altitude.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "altitude.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTinput']/field[@name='hr']"
		[Register ("hr")]
		public int Hr {
			get {
				const string __id = "hr.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "hr.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTinput']/field[@name='hrQuality']"
		[Register ("hrQuality")]
		public int HrQuality {
			get {
				const string __id = "hrQuality.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "hrQuality.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTinput']/field[@name='rri']"
		[Register ("rri")]
		public int Rri {
			get {
				const string __id = "rri.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "rri.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTinput']/field[@name='speed']"
		[Register ("speed")]
		public int Speed {
			get {
				const string __id = "speed.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "speed.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTinput']/field[@name='steps']"
		[Register ("steps")]
		public int Steps {
			get {
				const string __id = "steps.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "steps.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTinput']/field[@name='userState']"
		[Register ("userState")]
		public int UserState {
			get {
				const string __id = "userState.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "userState.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTinput']/field[@name='watts']"
		[Register ("watts")]
		public int Watts {
			get {
				const string __id = "watts.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "watts.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("fi/firstbeat/ete/FBTinput", typeof (FBTinput));
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

		protected FBTinput (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTinput']/constructor[@name='FBTinput' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FBTinput ()
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
}
