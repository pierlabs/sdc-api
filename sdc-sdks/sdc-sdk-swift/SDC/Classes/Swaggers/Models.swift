// Models.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation

protocol JSONEncodable {
    func encodeToJSON() -> AnyObject
}

public class Response<T> {
    public let statusCode: Int
    public let header: [String: String]
    public let body: T

    public init(statusCode: Int, header: [String: String], body: T) {
        self.statusCode = statusCode
        self.header = header
        self.body = body
    }

    public convenience init(response: NSHTTPURLResponse, body: T) {
        let rawHeader = response.allHeaderFields
        var header = [String:String]()
        for (key, value) in rawHeader {
            header[key as! String] = value as? String
        }
        self.init(statusCode: response.statusCode, header: header, body: body)
    }
}

private var once = dispatch_once_t()
class Decoders {
    static private var decoders = Dictionary<String, ((AnyObject) -> AnyObject)>()
    
    static func addDecoder<T>(clazz clazz: T.Type, decoder: ((AnyObject) -> T)) {
        let key = "\(T.self)"
        decoders[key] = { decoder($0) as! AnyObject }
    }
    
    static func decode<T>(clazz clazz: [T].Type, source: AnyObject) -> [T] {
        let array = source as! [AnyObject]
        return array.map { Decoders.decode(clazz: T.self, source: $0) }
    }
    
    static func decode<T, Key: Hashable>(clazz clazz: [Key:T].Type, source: AnyObject) -> [Key:T] {
        let sourceDictinoary = source as! [Key: AnyObject]
        var dictionary = [Key:T]()
        for (key, value) in sourceDictinoary {
            dictionary[key] = Decoders.decode(clazz: T.self, source: value)
        }
        return dictionary
    }
    
    static func decode<T>(clazz clazz: T.Type, source: AnyObject) -> T {
        initialize()
        if source is T {
            return source as! T
        }
        
        let key = "\(T.self)"
        if let decoder = decoders[key] {
           return decoder(source) as! T
        } else {
            fatalError("Source \(source) is not convertible to type \(clazz): Maybe swagger file is insufficient")
        }
    }

    static func decodeOptional<T>(clazz clazz: T.Type, source: AnyObject?) -> T? {
        if source is NSNull {
            return nil
        }
        return source.map { (source: AnyObject) -> T in
            Decoders.decode(clazz: clazz, source: source)
        }
    }

    static func decodeOptional<T>(clazz clazz: [T].Type, source: AnyObject?) -> [T]? {
        if source is NSNull {
            return nil
        }
        return source.map { (someSource: AnyObject) -> [T] in
            Decoders.decode(clazz: clazz, source: someSource)
        }
    }

    static func decodeOptional<T, Key: Hashable>(clazz clazz: [Key:T].Type, source: AnyObject?) -> [Key:T]? {
        if source is NSNull {
            return nil
        }
        return source.map { (someSource: AnyObject) -> [Key:T] in
            Decoders.decode(clazz: clazz, source: someSource)
        }
    }
	
    static private func initialize() {
        dispatch_once(&once) {
            let formatters = [
                "yyyy-MM-dd",
                "yyyy-MM-dd'T'HH:mm:ssZZZZZ",
                "yyyy-MM-dd'T'HH:mm:ss.SSSZZZZZ",
                "yyyy-MM-dd'T'HH:mm:ss'Z'"
            ].map { (format: String) -> NSDateFormatter in
                let formatter = NSDateFormatter()
                formatter.dateFormat = format
                return formatter
            }
            // Decoder for NSDate
            Decoders.addDecoder(clazz: NSDate.self) { (source: AnyObject) -> NSDate in
               if let sourceString = source as? String {
                    for formatter in formatters {
                        if let date = formatter.dateFromString(sourceString) {
                            return date
                        }
                    }
                
                }
                if let sourceInt = source as? Int {
                    // treat as a java date
                    return NSDate(timeIntervalSince1970: Double(sourceInt / 1000) )
                }
                fatalError("formatter failed to parse \(source)")
            } 

			// Decoder for [Cartao]
            Decoders.addDecoder(clazz: [Cartao].self) { (source: AnyObject) -> [Cartao] in
                return Decoders.decode(clazz: [Cartao].self, source: source)
            }
			// Decoder for Cartao
            Decoders.addDecoder(clazz: Cartao.self) { (source: AnyObject) -> Cartao in
                let sourceDictionary = source as! [NSObject:AnyObject]
                let instance = Cartao()
                instance.cvv = Decoders.decodeOptional(clazz: String.self, source: sourceDictionary["cvv"])
                instance.id = Decoders.decodeOptional(clazz: Int.self, source: sourceDictionary["id"])
                instance.nome = Decoders.decodeOptional(clazz: String.self, source: sourceDictionary["nome"])
                instance.numero = Decoders.decodeOptional(clazz: String.self, source: sourceDictionary["numero"])
                instance.senha = Decoders.decodeOptional(clazz: String.self, source: sourceDictionary["senha"])
                instance.status = Cartao.Status(rawValue: (sourceDictionary["status"] as? String) ?? "") 
                return instance
            }
			

			// Decoder for [Conta]
            Decoders.addDecoder(clazz: [Conta].self) { (source: AnyObject) -> [Conta] in
                return Decoders.decode(clazz: [Conta].self, source: source)
            }
			// Decoder for Conta
            Decoders.addDecoder(clazz: Conta.self) { (source: AnyObject) -> Conta in
                let sourceDictionary = source as! [NSObject:AnyObject]
                let instance = Conta()
                instance.id = Decoders.decodeOptional(clazz: Int.self, source: sourceDictionary["id"])
                instance.nome = Decoders.decodeOptional(clazz: String.self, source: sourceDictionary["nome"])
                return instance
            }
			

			// Decoder for [Limite]
            Decoders.addDecoder(clazz: [Limite].self) { (source: AnyObject) -> [Limite] in
                return Decoders.decode(clazz: [Limite].self, source: source)
            }
			// Decoder for Limite
            Decoders.addDecoder(clazz: Limite.self) { (source: AnyObject) -> Limite in
                let sourceDictionary = source as! [NSObject:AnyObject]
                let instance = Limite()
                instance.msg = Decoders.decodeOptional(clazz: String.self, source: sourceDictionary["msg"])
                instance.valor = Decoders.decodeOptional(clazz: Double.self, source: sourceDictionary["valor"])
                return instance
            }
			

			// Decoder for [Response]
            Decoders.addDecoder(clazz: [Response].self) { (source: AnyObject) -> [Response] in
                return Decoders.decode(clazz: [Response].self, source: source)
            }
			// Decoder for Response
            Decoders.addDecoder(clazz: Response.self) { (source: AnyObject) -> Response in
                let sourceDictionary = source as! [NSObject:AnyObject]
                let instance = Response()
                instance.msg = Decoders.decodeOptional(clazz: String.self, source: sourceDictionary["msg"])
                return instance
            }
			
        }
    }
}