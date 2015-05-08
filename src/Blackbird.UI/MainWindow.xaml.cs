﻿using System;
using Blackbird.WPF.BlackBirdSystem;
using Blackbird.WPF.Logging;
using BruTile.Web;
using Mapsui.Layers;
using Mapsui.UI.Xaml;

namespace Blackbird.WPF
{
    public partial class MainWindow
    {
        private readonly BlackbirdSystem _blackBirdSystem;

        public MainWindow()
        {
            InitializeComponent();
            Log4netLogger.Debug("Starting program");

            var blackBirdSystemInfoObject = new BlackbirdSystemInfoObject
            {
                MapControl = MapControl
            };

            _blackBirdSystem = new BlackbirdSystem(this, blackBirdSystemInfoObject);

            AddOsm();
        }

        private void AddOsm()
        {
            var osm = new TileLayer(new OsmTileSource()) { Name = "osm", Tag = Guid.Parse("7D1897F4-6D45-4FBA-919B-F39A7E8B8938").ToString() };
            _blackBirdSystem.LayerHelper.AddBackgroundLayer(osm);
        }
    }
}
