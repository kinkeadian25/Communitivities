import { DetailViewProps } from "react-calendar";

export interface ServerError {
    statusCode: number;
    message: string;
    details: string;

}