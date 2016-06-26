# LiskSharp
(c) Raj Bandi 2016, MIT Licence

App Veyor: [![Build status](https://ci.appveyor.com/api/projects/status/ivsvl8jg4oi2mjq7?svg=true)](https://ci.appveyor.com/project/Rajbandi/lisksharp)

Travis-CI: [![Build status](https://travis-ci.org/Rajbandi/LiskSharp.svg?branch=master)](https://travis-ci.org/Rajbandi/LiskSharp)

#Introduction

Lisk meets C#.Net

LiskSharp is cross platform  library based on Lisk (https://www.lisk.io) and entirely rewritten in C# without any node.js depedencies. Lisksharp core api is a PCL library.  Currently it supports Windows (including windows 8, 10 and windows phone), Linux and Mac, Xamarin mobile. 

### Development Environment

#### Frameworks
1. .Net 4.6
2. Mono.Net (Linux & Mac)

#### Editors
1. Visual Studio 2015 
2. Xamarin Studio 6

#### Third party dependencies
1. NBitcoin
2. Chaos.Nacl
3. Newtonsoft.json
4. NUnit

# Features
- Native Bip32 Mnuemonic passphrase generation.
- Native Lisk Address generation from a given BIP32 Mnuemonic passphrase.
- Sign and Verify message bytes with private key. 
- Calculate transaction and dapp bytes.
- API facade for Lisk public api (/api/*) (complete api)
- API facade for Lisk peer level api (/peer/*) (partial, see underdevelopment and roadmap)

# Lisk api
Every Lisk node provides 2 api's 

1. Public api (/api/*)
2. Peer api (/peer/*)

All the api requests initiated from LiskSharpsupports both synchronous and asynchronous. 

##public api

LiskSharp supports complete Lisk public api categorized as below. 

- Accounts (/api/accounts/*)
- Blocks (/api/blocks/*)
- Delegates (/api/delegates/*)
- Loader (/api/loader/*)
- Peers (/api/peers/*)
- Multisignatures (/api/multisignatures)
- Signatures (/api/signatures/*)
- Transactions (/api/transactions/*)

## Peer api
Lisksharp supports following peer related api. Still under development

- Peer list (/peer/list)
- Peer blocks (/peer/blocks)
- Peer height (/peer/height) 

#### Under development
- Peer transaction (/peer/transaction)
- Peer blocks common (/peer/blocks/common)
- Peer signatures (/peer/signatures)
- Peer dapp request (/peer/dapp/request)
- Peer dapp message (/peer/dapp/message)


# Under development
- Peer API facade. Currently it supports /peer/list, /peer/blocks, /peer/height. 
- Logic to create new blocks,  transactions, votes.
- DappMan, a dapp manager library for building dapps with or without git.
- DappManCli, a cross platform dapp command line to create, uupdate and remove dapps.


#RoadMap 

I'm working on this project part time and contributing in my free time. Other developers are most welcome if you want to help this project.

- Standalone server (as window service or background worker) with api, database, delegates and broadcast to other peers.
- Windows native client.
- Windows 8, phone & 10 apps.
- Android and IOS(IPhone) native apps ( will be faster than web version).



# Examples

- Generate BIP32 Mneumonic passphrase
```
var secret = CryptoHelper.GenerateSecret(); 
Console.WriteLine(secret); 
//cabbage chief join task universe hello grab slush page exit update brisk
```
- Generate a new Lisk address
```
var secret = "cabbage chief join task universe hello grab slush page exit update brisk"; 
 var address = CryptoHelper.GetAddress(secret);
 //10861956178781184496L
 ```
- Sign and Verify a message bytes
```
 var secret = "cabbage chief join task universe hello grab slush page exit update brisk"; 
 var address = CryptoHelper.GetAddress(secret);
 // address = { Id:"10861956178781184496L", KeyPair:{PublicKey:..., PrivateKey:...}}
 
 var keypair = address.KeyPair;
 var message = "This is my first message, testing sign and verify"
 var messageBytes = Encoding.UTF8.GetBytes(message);
 
 //Signs a message with private key
 
 var signatureBytes = CryptoHelper.Sign(messageBytes, keypair.PrivateKey);
 
 var signatureInHex = signatureBytes.ToHex();
 
 var isVerified = CryptoHelper.Verify(signatureBytes, keypair.PublicKey);
//If isVerified = true, message verified correctly. 

 ```
- Public api examples

```
  ILiskNodeApi  _api = new LiskNodeApi(new ApiInfo
            {
                //Host = "yourhostip",
                //Port = "port"
                UseHttps = true
            });
  
  //  /api/peers/
  var response = await _api.GetPeersAsync(); 
  
  // /api/peers/get
  var response = await _api.GetPeerAsync(new PeerRequest
            {
                Ip = "104.251.218.222",
                Port = "8000"
            });
  
  // /api/peers/version
    var version = await _api.GetVersionAsync();
  
  // /api/accounts/open
  var response = await _api.OpenAccountAsync(new OpenAccountRequest
            {
                Secret= "cabbage chief join task universe hello grab slush page exit update brisk"
            });
     var _account = response.Account;
     
  // /api/accounts/getBalance
  var response = await _api.GetAccountBalanceAsync(new AccountRequest
            {
                Address = _account.Address
            });
            
  // /api/delegates/
  var response = await _api.GetDelegatesAsync();
  
  // /api/delegates/fee
  var response = await _api.GetDelegateFeeAsync();
  
  // /api/signatures/fee
  var response = await _api.GetSignatureFeeAsync();
  
  // /api/transactions/get
  var response = await _api.GetTransactionAsync(new TransactionRequest
            {
            Id = "15748634892930294330"
            });
  ...
  ```
