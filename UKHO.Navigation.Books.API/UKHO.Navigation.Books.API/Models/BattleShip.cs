﻿namespace UKHO.Navigation.Books.API.Models;

public class BattleShip : ShipBase
{
    public int NumberOfGuns { get; set; }

    public bool Helipad { get; set; }
}

