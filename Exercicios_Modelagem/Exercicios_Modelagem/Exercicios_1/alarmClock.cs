using Exercicios_Modelagem1;
using System;

public class alarmClock : HouseholdObjects
{
	//Toque do alarme
	public String ringSound;
	//Volume do alarme
	public int ringVolume;
	public int ringInterval;
	public int snoozeInterval;
	public bool snoozeActive;
	public DateTime alarmDayHour;
	public String alarmName;

	public void setAlarm( DateTime alarmDayHour, String alarmName)
    {
		this.alarmDayHour = alarmDayHour;
		this.alarmName = alarmName;
		turnOn();
	}

	public void cancelAlarm()
	{
		turnOff();
	}

	public bool playRing()
    {
		if (DateTime.Now == alarmDayHour && this.active) return true;
		else return false;
    }

	public void adjustRing( String ringSound, int ringVolume, int ringInterval )
    {
		this.ringSound = ringSound;
		this.ringVolume = ringVolume;
		this.ringInterval = ringInterval;
	}

	public void acceptSnooze( int snoozeInterval )
    {
		this.snoozeInterval = snoozeInterval;
		this.snoozeActive = true;
	}
	public void declineSnooze()
	{
		this.snoozeActive = false;
	}

	public override void showDescription()
    {
		Console.WriteLine("\nTipo: Despertador");
		base.showDescription();
		Console.WriteLine(
				"Nome do alarme: {0}\n" +
                "Despertar às: {1}\n" +
                "Som de alarme: {2}\n" +
                "Volume de alarme: {3}\n" +
                "Duração do alarme: {4} minutos\n" +
                "Modo soneca ativo? {5}\n" +
                "Duração do modo soneca: {6} minutos\n", alarmName, alarmDayHour, ringSound, ringVolume, ringInterval, snoozeActive, snoozeInterval );
    }
}