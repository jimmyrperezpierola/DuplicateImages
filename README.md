# Warp Server

Warp Server is a spacecraft telemetry processing component
compatible with NASA's [Open MCT](https://nasa.github.io/openmct/).
Open MCT (Open Mission Control Technologies) is a next-generation
mission control framework for visualization of data on desktop and
mobile devices. Warp and OpenMCT are developed at NASA's Ames
Research Center, and are being used for spacecraft data analysis as
well as planning and operation of experimental rover systems.

Warp Server takes binary telemetry packets compatible with the
[CCSDS](http://ccsds.org/) international standard and makes them
available to Open MCT via REST and WebSocket interfaces.  Because
Open MCT does not decommutate (decode) binary packets, Warp performs
this function using a telemetry dictionary before sending it decoded
telemetry values.

## Modes

Warp can run in several modes:

1. Realtime mode

In realtime mode, warp receives packets from one of several kinds of
sources (described below), 

2. Session mode

In session mode, Warp loads a database containing a set of
previously-recorded telemetry packets, called a telemetry session,
and responds to queries about them via a rest interface.  These
queries are usually of the form 'return the values of these
telemetry points over this interval of time'.  Before running warp
in session mode, the program can be used to build the packet
database from another source like a binary file or a directory of
files.

3. Combined mode

In combined mode, warp receives a realtime packet stream, builds a
packet database on-the-fly, and responds to both REST queries and
WebSocket session requests.


## Commands

To list available commands, either run `warp` with no parameters or
execute `docker help`:

warp commands take this form:

```warp [COMMAND] [OPTIONS] [ARG ...]```


warp realtime
warp session
warp combined
warp history

warp walk
warp filter
warp decode

warp config
