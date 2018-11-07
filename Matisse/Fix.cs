using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

#pragma warning disable IDE1006 // 命名样式

namespace Com.Zhihu.Matisse.Internal.Model
{
    public partial class AlbumCollection
    {
        void Android.Support.V4.App.LoaderManager.ILoaderCallbacks.OnLoadFinished(Android.Support.V4.Content.Loader loader, Java.Lang.Object data)
            => OnLoadFinished(loader, data.JavaCast<Android.Database.ICursor>());
    }

    public partial class AlbumMediaCollection
    {
        void Android.Support.V4.App.LoaderManager.ILoaderCallbacks.OnLoadFinished(Android.Support.V4.Content.Loader loader, Java.Lang.Object data)
            => OnLoadFinished(loader, data.JavaCast<Android.Database.ICursor>());
    }
}

namespace Com.Zhihu.Matisse.Internal.UI.Adapter
{
    public partial class AlbumMediaAdapter
    {
        public int getItemViewType(int position, Android.Database.ICursor cursor) => GetItemViewType(position, cursor);
    }

    public abstract partial class RecyclerViewCursorAdapter
    {
        private void OnBindViewHolder(Java.Lang.Object holder, Android.Database.ICursor cursor)
            => OnBindViewHolder(holder.JavaCast<Android.Support.V7.Widget.RecyclerView.ViewHolder>(), cursor);
        private void OnBindViewHolder(Java.Lang.Object holder, int position)
            => OnBindViewHolder(holder.JavaCast<Android.Support.V7.Widget.RecyclerView.ViewHolder>(), position);
    }
}