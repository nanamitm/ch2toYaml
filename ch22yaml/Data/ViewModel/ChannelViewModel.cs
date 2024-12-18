﻿namespace ch22yaml.Data
{
    public class ChannelViewModel : ViewModelBase
    {
        public ChannelViewModel(Ch2 ch)
        {
            this.mCH = ch;
        }

        private Ch2 mCH { get; set; }

        public string Name { get => mCH.Name; set => mCH.Name = value; }

        public CHType Type { get => mCH.Type;}

        public ushort Channel { get => mCH.Channel; set => mCH.Channel = value; }

        public ushort ServiceID { get => mCH.ServiceID; set => mCH.ServiceID = value; }

        public byte Space { get => mCH.TuningSpace; set => mCH.TuningSpace = value; }

        public bool IsEnabled { get => mCH.Enabled; set => mCH.Enabled = value; }

        public MirakurunChannel GetMirakurunChannel() => mCH.ToMirakurunChannel();

    }
}
