import {Session_Data} from "../../API_Other_Models/Session_Models/SessionData";

export interface Get_By_ID_Order_Data{
    session?: Session_Data;
    
    orderId:number;
}