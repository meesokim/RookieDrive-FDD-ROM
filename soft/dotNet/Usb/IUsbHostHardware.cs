﻿namespace Konamiman.RookieDrive.Usb
{
    public interface IUsbHostHardware
    {
        void HardwareReset();

        bool DeviceIsConnected();

        UsbTransferResult ExecuteControlTransfer(byte[] commandBytes, byte[] dataBuffer, int dataBufferIndex, int deviceAddress, int endpointPacketSize, int endpointNumber = 0);

        UsbTransferResult ExecuteDataInTransfer(byte[] dataBuffer, int dataBufferIndex, int dataLength, int deviceAddress, int endpointNumber, int endpointPacketSize, int toggleBit);

        UsbTransferResult ExecuteDataOutTransfer(byte[] dataBuffer, int dataBufferIndex, int dataLength, int deviceAddress, int endpointNumber, int endpointPacketSize, int toggleBit);
    }
}
